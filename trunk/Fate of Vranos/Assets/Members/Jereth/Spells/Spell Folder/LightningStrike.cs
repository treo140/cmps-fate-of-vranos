using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LightningStrike : Spell 
{

	public LightningStrike(float damage, int cost, SpellEffect effect, Dictionary<string, GameObject> Spells, 
	                       GameObject Platform, TargetType tar,
	                       GameObject caster)
	{

		Name = "Lightning Strike";
		Description = "Strike your enemy with fury of an angry god!";
		Damage = damage;
		Cost = cost;
		Effect = effect;
		particleSystem = new List<GameObject> ();
		particleSystem.Add (Spells ["Lightning Strike"]);
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
		// Reference the start position of the Lightning Strike
		Vector3 spellStart = Caster.transform.position;

		// Instatiate the Lightning Strike
		GameObject GO;
		GO = GameObject.Instantiate (particleSystem [0], spellStart, particleSystem [0].transform.rotation) as GameObject;

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
