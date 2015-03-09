using UnityEngine;
using System.Collections;

public class Mission1 : MonoBehaviour {	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col){		
		QuestManager questManager = col.GetComponent<QuestManager> ();
		if(col.tag == "Player" & questManager.storyProgress == 0 & questManager.currentQuest.condition > questManager.currentQuest.progress & questManager.currentQuest.active){
			questManager.currentQuest.progress++;
			questManager.updateQuest();
		}
	}
}
