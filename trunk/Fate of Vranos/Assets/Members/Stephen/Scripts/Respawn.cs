using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	//public Transform SpawnPoint;
	public Vector3 Pos= new Vector3(947, 43, 1529);
	private GameObject dummy;
	private bool portalenter= false;
	void Update () {

	}


	void OnTriggerEnter(Collider other){
		if (other.name == "waterCollision") {
			transform.position =Pos;//= SpawnPoint.position;
			Debug.Log("in the water!!!!");
		}

		if (other.name == "Checkpoint") {
			Pos = other.transform.position;
			Debug.Log("Entering a new checkpoint");
		}
	}
}
