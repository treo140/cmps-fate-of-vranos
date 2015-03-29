using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RocketBarrage : Spell 
{

	public RocketBarrage(float damage, int cost, SpellEffect spellEffect, Dictionary<string, GameObject> Spells,
	                     GameObject Platform, TargetType tar,
	                     GameObject caster)
	{
		Name = "Rocket Barrage";
		Description = "Open a portal to a different demonsion and bring a barrage of deadly objects.";
		Damage = damage;
		Cost = cost;
		Effect = spellEffect;
		particleSystem = new List<GameObject> ();
		particleSystem.Add (Spells ["Tear in Time"]);
		particleSystem.Add (Spells ["Rocket Barrage"]);
		tarType = tar;
		platform = Platform;
		Caster = caster;

	}


	public override void Cast ()
	{
		//throw new System.NotImplementedException ();
	}

	public override void Cast (GameObject target)
	{


		Vector3 spellStart = platform.transform.position; // Used to bring the particle system to the caster
		// (i.e. the Spell Transform)
		
		//////////////////////
		// make a list of Instantiated GameObjects for the spell to reference
		List<GameObject> GO = new List<GameObject>();
		
		// Instantiate the Portal
		GO.Add(GameObject.Instantiate(particleSystem[0], new Vector3 (spellStart.x, spellStart.y,
		                                                              spellStart.z), particleSystem[0].transform.rotation) as GameObject);
		
		// Set the gameobject to false
		GO [0].SetActive (false);
		
		
		spellStart = Caster.transform.position;
		
		// Instantiate the Rocket
		GO.Add(GameObject.Instantiate(particleSystem[1], new Vector3 (spellStart.x, spellStart.y,
		                                                              spellStart.z), particleSystem[1].transform.rotation) as GameObject);
		
		// Set the GameObject to false
		GO [1].SetActive (false);
		GO [1].transform.position = new Vector3(0,0.5f,0);
		
		EffectSettings eSettings = GO[0].GetComponent<EffectSettings> ();
		EffectSettings e2Settings = GO [1].GetComponent<EffectSettings> ();
		
		// Give the Portal a target
		eSettings.Target = target.transform.parent.gameObject;
		// Give the Rocket the same target as the Portal
		e2Settings.Target = eSettings.Target;
		
		// Start playing the Portal
		GO [0].SetActive (true);
		Debug.Log (GO [0].name);
		// Temporarily set the Rocket active to alter elements
		GO [1].SetActive (true);
		Debug.Log (GO [1].name);
		
		TearInTimeBehavior tearBehave;
		
		tearBehave = GO[0].GetComponent<TearInTimeBehavior>();
		tearBehave.Rocket = GO [1];
		
		// Set the Rocket's parent as the Portal
		GO [1].SetParent(GO[0]);
		
		GO [1].SetActive (false);

	}

	public override void Cast (System.Collections.Generic.List<GameObject> targets)
	{
		//throw new System.NotImplementedException ();
	}

	public override void Animate ()
	{
		//throw new System.NotImplementedException ();
	}

	public override void doDamage ()
	{
		//throw new System.NotImplementedException ();
	}


}
