using UnityEngine;
using System.Collections;

public class EnemyBattleController : MonoBehaviour {
	private GameObject player;
	public bool canMove = false;
	private NavMeshAgent agent;
	
	private Vector3 startPosition;


	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		agent = GetComponent<NavMeshAgent> ();
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (agent.enabled) {
			if (canMove) {
				agent.SetDestination (player.transform.position);
			} else
				agent.SetDestination (startPosition);
		}
	}

	
	public void stopEnemy(){
		canMove = false;
		startPosition = transform.position;

		agent.enabled = false;
	}

}
