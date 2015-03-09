using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class QuestManager : MonoBehaviour {
	public List<QuestClass> questList = new List<QuestClass>();
	private QuestClass tempQuest = new QuestClass();
	public int storyProgress = 0;
	public QuestClass currentQuest;

	public List<GameObject> skeletons;
	public List<GameObject> armor;

	public UILabel progressWindow;
	public UILabel dialogLabel;

	public GameObject questLight;

	private bool byNPC = false;

	// Use this for initialization
	void Start () {
		/*tempQuest.name = "Test 01";
		tempQuest.description = "Find the light";
		tempQuest.dialog = "It gets dark here at night, can you find the guiding light so it wont be so dark?";
		tempQuest.completionDialog = "Thank you for finding the light, now we will be able to  see once it is dark.";
		tempQuest.condition = 1;
		questList.Add (tempQuest);
		*/

		tempQuest = new QuestClass();
		tempQuest.name = "Pesky Weeds";
		tempQuest.description = "Evil Plant Heads";
		tempQuest.dialog = "You think yourself strong enough to defeat the 4 skeletons plaguing this land? Prove yourself! Bring me 5 evil plant heads!";
		tempQuest.completionDialog = "You have proven yourself, I will now tell you where the skeletons can be found.";
		tempQuest.condition = 5;
		questList.Add (tempQuest);

		tempQuest = new QuestClass();
		tempQuest.name = "Astaroth";
		tempQuest.description = "Astaroth";
		tempQuest.dialog = "Astarath, once a great prince, can be found behind the mountains of your house!";
		tempQuest.completionDialog = "You have defeated him? Excellent!";
		tempQuest.condition = 1;
		questList.Add (tempQuest);

		tempQuest = new QuestClass();
		tempQuest.name = "Skargrid";
		tempQuest.description = "Skargrid";
		tempQuest.dialog = "Skargrid can be found deep into the mountains to the north, he must be destroyed!";
		tempQuest.completionDialog = "I was worried you would not defeat him, this is excellent news";
		tempQuest.condition = 1;
		questList.Add (tempQuest);
		
		tempQuest = new QuestClass();
		tempQuest.name = "Vulgrim";
		tempQuest.description = "Vulgrim";
		tempQuest.dialog = "I could've sworn I saw Vulgrim across from where Skargrid was.";
		tempQuest.completionDialog = "At this rate, The Fate of Vranos will be sealed!";
		tempQuest.condition = 1;
		questList.Add (tempQuest);
		
		tempQuest = new QuestClass();
		tempQuest.name = "Drachkon";
		tempQuest.description = "Drachkon";
		tempQuest.dialog = "Drachkon is the most fearsome of all, he can be found at the very end of the island";
		tempQuest.completionDialog = "You did it? Wow, I guess you're done, thanks.";
		tempQuest.condition = 1;
		questList.Add (tempQuest);
		
		
		
		

		currentQuest = questList [0];
	}
	
	// Update is called once per frame
	void Update () {

		if (byNPC & Input.GetKeyDown(KeyCode.E)) {
			showDialog();
		}

	}
	
	void OnTriggerEnter(Collider col){
		if (col.tag == "NPC") {			
			byNPC = true;
			showDialog();
		}
	}
	
	public void OnTriggerExit(Collider col){		
		if (col.tag == "NPC") {
			StartCoroutine(UpdateDialog());
		}
	}

	public void showDialog(){
		if(currentQuest.active == false){
			dialogLabel.text = currentQuest.dialog;
			currentQuest.active = true;
			
			if(storyProgress < questList.Count) {
				armor[storyProgress].SetActive(true);
				if (storyProgress > 0)
					skeletons[storyProgress - 1].SetActive(true);
				StartCoroutine(PressE());
				updateQuest();
			}
		}
		else{
			completeQuest();
		}
	}

	IEnumerator UpdateDialog() {
				byNPC = false;
				updateQuest ();
				yield return new WaitForSeconds (4);
				dialogLabel.text = "";
		}

	IEnumerator PressE(){
		yield return new WaitForSeconds (2);
		if(dialogLabel.text == currentQuest.dialog || dialogLabel.text == currentQuest.completionDialog)
			dialogLabel.text = dialogLabel.text + " (Press 'E' to continue).";
	}

	public void completeQuest(){
		if (questList [storyProgress].condition == questList [storyProgress].progress) {
			dialogLabel.text = currentQuest.completionDialog;
			currentQuest.active = false;
			storyProgress ++;
			if (storyProgress != questList.Count) 
				currentQuest = questList[storyProgress];
		}else
			dialogLabel.text = currentQuest.description;
	}

	public void updateQuest(){
		progressWindow.text = currentQuest.description + " (" + currentQuest.progress + "/" + currentQuest.condition+ ")";
		if (currentQuest.progress == currentQuest.condition) {
			questLight.SetActive (true);
		} else
			questLight.SetActive (false);
	}

	public void incrementDialog(){
	}
}
