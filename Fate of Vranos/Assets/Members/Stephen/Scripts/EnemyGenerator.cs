using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyGenerator : MonoBehaviour {
	public enum State {
		Idle,
		Initialize,
		Setup,
		SpawnEnemy
	}

	public GameObject[] enemyPrefabs;		//array holding all prefabs of enemies
	public GameObject[] spawnPoints;		//array will hold a reference to all spawnpoints in the scene

	public State state; 					//local variable that holds the current state


	void Awake(){
		state = EnemyGenerator.State.Initialize;
	}

	IEnumerator Start(){
		while(true){
			switch(state){
			case State.Initialize:
				Initialize();
				break;
			case State.Setup:
				Setup();
				break;
			case State.SpawnEnemy:
				SpawnEnemy();
				break;
			}
			yield return 0;
		}
	}
	//makes sure everything is initialized before going to the next step
	private void Initialize(){
		Debug.Log ("***inside initialize function***");
		if (!CheckForEnemyPrefab ())
			return;
		if (!CheckForSpawnPoints ())
			return;
		state = EnemyGenerator.State.Setup;
	}

	//makes sure everything is setup, may use, may not.
	private void Setup(){
		Debug.Log ("***inside Setup function***");

		state = EnemyGenerator.State.SpawnEnemy;
	}

	//spawn an enemy if you have an open spawn point
	private void SpawnEnemy(){
		Debug.Log ("***Spawning Enemies***");
		GameObject[] gos = AvailableSpawnPoints ();
		for (int cnt = 0; cnt < gos.Length; cnt ++) {
			GameObject go = Instantiate(enemyPrefabs[Random.Range(0, enemyPrefabs.Length)],
			                            gos[cnt].transform.position,
			                            Quaternion.identity
			                            ) as GameObject;

			go.transform.parent = gos[cnt].transform;
				
		}

		state = EnemyGenerator.State.Idle;
	}

	//check to see that we have at least one enemy prefab to spawn
	private bool CheckForEnemyPrefab(){
		if (enemyPrefabs.Length > 0)
						return true;
				else
						return false;

	}

	//check to see if we have at least one spawn point for enemies
	private bool CheckForSpawnPoints(){
		if (spawnPoints.Length > 0)
						return true;
				else
						return false;
	}

	//generate a list of available spawn points that do not have any enemies childed to them
	private GameObject[] AvailableSpawnPoints(){
		List<GameObject> gos = new List<GameObject>();

		for (int cnt =0; cnt < spawnPoints.Length; cnt ++){
			if(spawnPoints[cnt].transform.childCount == 0){
				Debug.Log (" *** spawn point available *** ");
				gos.Add(spawnPoints[cnt]);
			}
		}
		return gos.ToArray();

	}


}

