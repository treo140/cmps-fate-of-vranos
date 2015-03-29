using UnityEngine;
using System.Collections;

public class ParticleSystemDestroyer : MonoBehaviour {

	public float currentTime;
	public float endTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		currentTime += Time.deltaTime;

		if (currentTime >= endTime)
						Destroy (gameObject, 1);
	
	}
}
