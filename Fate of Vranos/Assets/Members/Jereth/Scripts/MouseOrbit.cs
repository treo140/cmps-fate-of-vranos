﻿using UnityEngine;
using System.Collections;

/*
 * This is the MouseOrbit Script from the standard assests package and has been altered from a
 * Javascript version to a C# version script
 * 
 */
public class MouseOrbit : MonoBehaviour {

	public Transform target;
	public float distance = 10.0f;
	
	public float xSpeed = 250.0f;
	public float ySpeed = 120.0f;
	
	public float yMinLimit = -20f;
	public float yMaxLimit = 80f;
	
	private float x = 0.0f;
	private float y = 0.0f;
		
	void Start () {
		Vector3 angles = transform.eulerAngles;
		x = angles.y;
		y = angles.x;
		Screen.lockCursor = true;

	}
	
	void LateUpdate (){
		
		Screen.lockCursor = true;
		Screen.lockCursor = false;
		if (target) {
			x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
			y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
			
			y = ClampAngle(y, yMinLimit, yMaxLimit);
			
			Quaternion rotation = Quaternion.Euler(y, x, 0);
			Vector3 position = rotation * new Vector3(0.0f, 0.0f, -distance) + target.position;// point camera looks towards
			
			transform.rotation = rotation;
			transform.position = position;
		}
	}
	
	float ClampAngle (float angle, float min, float max) {
		if (angle < -360)
			angle += 360;
		if (angle > 360)
			angle -= 360;
		return Mathf.Clamp (angle, min, max);
	}
}
