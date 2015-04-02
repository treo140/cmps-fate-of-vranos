using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PartyManager : MonoBehaviour {

	public List<GameObject> models = new List<GameObject> ();
	public List<string> modelNames = new List<string>();
	public Dictionary<string, GameObject> allModels = new Dictionary<string, GameObject>();


	// Use this for initialization
	void Start () {

		for (int i = 0; i < models.Count; i++) 
		{
			allModels.Add(modelNames[i], models[i]);
			Debug.Log(modelNames[i] + " " + models[i].name);
		}


	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public GameObject GetModel(string name)
	{

		return allModels [name];

	}





}
