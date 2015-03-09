using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	
	private Vector3 velocity = Vector3.zero;
	public float smoothTime;
	public GameObject CamPos;

	public GameObject player;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void LateUpdate () {
		gameObject.transform.position = Vector3.SmoothDamp(camera.transform.position, CamPos.transform.position, ref velocity, smoothTime);
		gameObject.transform.LookAt (player.transform);
	}
}
