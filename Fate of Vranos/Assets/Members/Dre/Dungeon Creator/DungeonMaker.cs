using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DungeonMaker : MonoBehaviour {
	public List<PlatformClass> currentPlatforms;
	public List<PlatformClass> allPlatforms;

	public int size;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Reset all Platforms and then create dungeon
		if (Input.GetKeyDown (KeyCode.Tab)) {
			CreateDungeon(size);
		}
	}

	public void CreateDungeon(int numStages){		
		foreach (PlatformClass platform in allPlatforms) {
			if(currentPlatforms.Contains(platform))
				currentPlatforms.Remove (platform);
			foreach(BridgeClass bridge in platform.bridges){
				bridge.gameObject.SetActive(false);
			}
			platform.gameObject.SetActive(false);
			platform.distance = 0;
			platform.gameObject.renderer.material.color = Color.white;
		}


		PlatformClass newPlatform;
		BridgeClass newBridge;

		//Pick random first platform
		newPlatform = allPlatforms [Random.Range (0, allPlatforms.Count)];
		newPlatform.gameObject.SetActive(true);
		currentPlatforms.Add(newPlatform);
		PlatformClass furthest = newPlatform;


		numStages --;

		//Adding other platforms
		for (int i = 0; i < numStages; i++) {
			//Pick random platform
			newPlatform = currentPlatforms[Random.Range(0,currentPlatforms.Count)];	
			//Pick random bridge
			newBridge = newPlatform.bridges[Random.Range(0,newPlatform.bridges.Count)];

			//if only one of the platform that the bridge is connected to is in the list of current platforms...
			if(currentPlatforms.Contains(newBridge.platform1)^currentPlatforms.Contains(newBridge.platform2)){
	
				//... make the bridge and both platforms visible and...
				newBridge.gameObject.SetActive(true);
				newBridge.platform1.gameObject.SetActive(true);
				newBridge.platform2.gameObject.SetActive(true);	

				//...Add the other platform to the list of current platforms
				if(currentPlatforms.Contains(newBridge.platform1)){
					newBridge.platform2.distance = newPlatform.distance + 1;
					currentPlatforms.Add(newBridge.platform2);
				}
				else{
					newBridge.platform1.distance = newPlatform.distance + 1;
					currentPlatforms.Add(newBridge.platform1);
				}
			}
			else{
				//...Otherwise, run through the loop again.
				i--;
			}
		}

		//Find the platform that is furthest from the starting platform;
		foreach (PlatformClass platform in currentPlatforms) {
			if(furthest.distance < platform.distance)
				furthest = platform;
		}

		//Logic for Creating Special Stages
		currentPlatforms[0].gameObject.renderer.material.color = Color.red;
		currentPlatforms [numStages].gameObject.renderer.material.color = Color.blue;
		furthest.gameObject.renderer.material.color = Color.green;
	}
}
