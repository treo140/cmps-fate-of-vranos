using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemyPrefab;
	public int enemyAmt;
	public GameObject[] enemyList;
	public float[] resTime;
	public float timeTilSpawn;

	// Use this for initialization
	void Start () {

		resTime = new float[enemyAmt];

		for (int i = 0; i < enemyAmt; i++) 
		{
			enemyList[i] = enemyPrefab; // populate the list
			enemyList[i].transform.position = new Vector3(transform.position.x + Random.Range(-collider.bounds.extents.x,collider.bounds.extents.x), transform.position.y + 2,transform.position.z + Random.Range(-collider.bounds.extents.x,collider.bounds.extents.x));
			Instantiate(enemyList[i]);

		}
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		for (int i = 0; i < enemyAmt; i++) 
		{
			if(resTime[i] > 0) // this monster is on cooldown for respawn
			{
				resTime[i] -= Time.deltaTime; // countdown until next respawn

				if(resTime[i] <= 0) // countdown overshot its mark
				{
					enemyList[i] = enemyPrefab; // insert a prefab into index
					// instantiate the enemy at a random spot within the area
					enemyList[i].transform.position = new Vector3(transform.position.x + Random.Range(-collider.bounds.extents.x,collider.bounds.extents.x), transform.position.y + 2,transform.position.z + Random.Range(-collider.bounds.extents.x,collider.bounds.extents.x));
					Instantiate(enemyList[i]);
					resTime[i] = 0; // reset the countdown to 0 to wait for the next time it needs to be used
				}

			}

		}

	}


	public void StartRespawnTimer()
	{
		for (int i = 0; i < enemyAmt; i++) 
		{
			if(resTime[i] == 0)
				resTime[i] = timeTilSpawn;
			return;
		}

	}


}
