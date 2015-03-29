using UnityEngine;
using System.Collections;

public class NatureTouchBehaviour : MonoBehaviour {

	public float currentTime;
	public float endTime;

	
	// Update is called once per frame
	void Update () 
	{

		currentTime += Time.deltaTime;

		if (currentTime >= endTime) 
		{

			Destroy(gameObject, 1);

		}
	
	}
}
