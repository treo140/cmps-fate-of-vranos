using UnityEngine;
using System.Collections;

public class QuestClass {

	public string name;
	public string description; //Description of Mission
	public string dialog; //Dialog for initial NPC interaction
	public string completionDialog; //Dialog to display once quest is completed
	public bool active = false; //Tells if mission is activated or not
	public int condition; //Represents the maximum value of progress
	public int progress = 0; //Increments to show quest progress
}
