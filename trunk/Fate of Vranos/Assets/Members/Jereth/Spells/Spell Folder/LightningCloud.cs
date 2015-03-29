using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LightningCloud : Spell 
{


	public LightningCloud(float damage, int cost, SpellEffect effect, Dictionary<string, GameObject> Spells, 
	                      GameObject Platform, TargetType tar,
	                      GameObject caster)
	{

		Name = "Lightning Storm";
		Description = "Summon the fury of the Gods!";
		Damage = damage;
		Cost = cost;
		Effect = effect;
		particleSystem = new List<GameObject> ();
		particleSystem.Add (Spells ["Lightning Cloud"]);
		platform = Platform;
		tarType = tar;
		Caster = caster;


	}


	public override void Cast ()
	{
		//throw new System.NotImplementedException ();
	}

	public override void Cast (GameObject target)
	{
		// Reference to the spell's target
		Vector3 tar = target.transform.position;

		// Instantiate the Lightning Cloud
		GameObject GO;
		GO = GameObject.Instantiate(particleSystem[0], new Vector3(tar.x, (tar.y + 5), tar.z),
		                            particleSystem[0].transform.rotation) as GameObject;

		// Grab the effect settings script to add its target
		EffectSettings eSettings = particleSystem [0].GetComponent<EffectSettings> ();
		eSettings.Target = target;

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
