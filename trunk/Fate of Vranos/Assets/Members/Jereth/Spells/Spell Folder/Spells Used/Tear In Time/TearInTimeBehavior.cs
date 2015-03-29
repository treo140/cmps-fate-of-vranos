using UnityEngine;
using System.Collections;

public class TearInTimeBehavior : MonoBehaviour {

	public float currentTime;
	public float endTime;
	public GameObject Rocket;
	public bool active = false;

	// Use this for initialization after it is enabled
	void OnEnable () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{

		currentTime += Time.deltaTime;

		if (currentTime >= endTime && !active) 
		{
			//Rocket = GameObject.Find("Big Rocket");
			Rocket.SetActive (true);
			active = true;
		}

		if (currentTime >= (endTime + 2))
						Destroy (gameObject, 1);

	}
}
