using UnityEngine;
using System.Collections;

public class FutureRocket : Spell 
{
	

	public FutureRocket(string name, string description, float damage, int cost, 
	                    SpellEffect spellEffect, GameObject pSystem, GameObject Platform, TargetType tar,
	                    GameObject caster)
	{
		Name = name;
		Description = description;
		Damage = damage;
		Cost = cost;
		Effect = spellEffect;
		particleSystem = pSystem;
		tarType = tar;
		platform = Platform;
		Caster = caster;

	}

	public override void Cast ()
	{

	}

	/*public override void Cast (GameObject[] targets)
	{
		GameObject[] rockets = new GameObject[targets.GetLength()]();
		EffectSettings[] eSettings = new EffectSettings[targets.GetLength()]();

		/*foreach (GameObject target in targets)
		{
			rockets = GameObject.Instantiate (particleSystem, new Vector3 (transform.position.x, (transform.position.y + 10f),
			                                                transform.position.z), prefab [0].transform.rotation) as GameObject;
		}

		for(int i = 0; i < targets.GetLength(); i++)
		{
			// for each of the targets I should instantiate a prefab to use for the attack and give it a target
			rockets[i] = GameObject.Instantiate(particleSystem, new Vector3 (transform.position.x, (transform.position.y + 10f),
			                                                                 transform.position.z), prefab [0].transform.rotation) as GameObject;
		}


	}*/


	public override void Cast (GameObject[] targets)
	{


		
	}

	public override void Cast(GameObject target)
	{

		Vector3 spellStart = Caster.transform.position;
		GameObject GO;
		GO = GameObject.Instantiate(particleSystem, new Vector3 (spellStart.x, (spellStart.y + 10f),
		                                                    spellStart.z), particleSystem.transform.rotation) as GameObject;

		EffectSettings eSettings = GO.GetComponent<EffectSettings> ();

		eSettings.Target = target;




	}

	public override void Animate ()
	{

	}

	public override void doDamage (/*GameObject target*/)
	{

		// Make a reference to the component that holds the targets health so you can do damage

		// Call a another damage calculation function if that is needed to implement the damage done




	}

}
