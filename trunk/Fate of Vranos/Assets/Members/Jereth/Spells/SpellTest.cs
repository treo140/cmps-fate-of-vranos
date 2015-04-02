using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpellTest : MonoBehaviour {

	public GameObject[] prefab;		// Array of spell prefabs to reference the spell to use
	public string[] spellName;		// Array of the spell names
	public Dictionary<string, GameObject> Spells; // Dictionary of spells
	public Spell meteor;			// reference to the spell in spellbook that is being used
	public GameObject[] target;		// Array of targets to attack
	public EffectSettings effectSettings;	// Reference to the effectsettings script on the spell prefab
	public GameObject GO;			// reference to the instantiated spell particle system
	public GameObject platform;		// reference to the platform to attack from
	public Vector3 parTrans;		// reference to the parent position of the instantiated
									// spell prefab
	//public GameObject[] SpellList; // Array of Spells to use to make the spell class object

	// Use this for initialization
	void Start () 
	{

		/*Spells = new Dictionary<string, GameObject> ();

		for (int i = 0; i < prefab.Length; i++) 
		{
			Spells.Add(spellName[i], prefab[i]);
			Debug.Log(spellName[i] + " " + prefab[i].name);
		}

		parTrans = transform.position;	// get the parent's transform vector
		InstanceObject();				// create the spell in spellbook and instantiate the prefab*/

	}

	void Awake ()
	{
	 
		Spells = new Dictionary<string, GameObject> ();
		
		for (int i = 0; i < prefab.Length; i++) 
		{
			Spells.Add(spellName[i], prefab[i]);
			Debug.Log(spellName[i] + " " + prefab[i].name);
		}
		
		parTrans = transform.position;	// get the parent's transform vector
		InstanceObject();				// create the spell in spellbook and instantiate the prefab

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.J)) 
		{
			// move the particle system to a new vector3 *MAY NOT BE NEEDED*
			//GO.transform.position = new Vector3(parTrans.x, parTrans.y, parTrans.z);
			// Cast the spell by sending an array of targets!
			meteor.Cast (target[0]);
		}

			


	}

	public void InstanceObject()
	{
		target[0] = GameObject.Find("Enemy Transform"); // Find the enemy's transform for the homing attacks

		//target[0] = GameObject.Find("_Aqua_Knight"); // Find the enemy's transform for the homing attacks

		//platform = GameObject.Find("Portal Transform");  // Not too sure what this is used for
		platform = GameObject.Find("Spell Transform");

		// Instantiate the spell prefab to hurt the enemy
		//GO = Instantiate (prefab [0], new Vector3 (transform.position.x, (transform.position.y + 10f),
		  //                                       transform.position.z), prefab [0].transform.rotation) as GameObject;

		// Set the Game Object's parent
		//GO.SetParent (transform.gameObject);

		// Get the effect settings of the particle system
		//effectSettings = GO.GetComponent<EffectSettings> ();
		//effectSettings.Target = target [0]; // set the target that needs to get hurt

		// move the particle system to a new place; the new vector3 will be different depending who is attacking
		//GO.transform.position = new Vector3(parTrans.x, parTrans.y, parTrans.z);

		// make sure the  particle system is set to false so it doesn't start playing yet
		//GO.SetActive (false);

		// make a spell in the spellbook so the player can use it to attack
		//meteor = new FireBall (50f, 1, SpellEffect.none, Spells, platform, TargetType.SingleEnemy, gameObject);
	}


	// *THIS FUNCTION MAY NOT BE USE* THIS IS YET TO BE DETERMINED.
	public void StopAnimation()
	{
		MoveOnGround isFinished;
		isFinished = GO.GetComponentInChildren<MoveOnGround> ();
		if (isFinished.isFinished) 
		{
			//GO.SetActive(true);
			//Destroy(meteor.particleSystem);
			Destroy (GO);
		}
	}
}
