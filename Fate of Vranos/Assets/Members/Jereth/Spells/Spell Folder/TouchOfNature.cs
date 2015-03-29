using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TouchOfNature : Spell 
{


	public TouchOfNature(float damage, int cost, SpellEffect spellEffect, Dictionary<string, GameObject> Spells,
	                     GameObject Platform, TargetType tar,
	                     GameObject caster)
	{

		Name = "Touch of Nature";
		Description = "Caster is granted help from Nature.";
		Damage = damage;
		Cost = cost;
		Effect = spellEffect;
		particleSystem = new List<GameObject> ();
		particleSystem.Add(Spells["Green Portal"]);
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
		// Get the vector of the person that will be buffed by the move
		Vector3 playerbuffed = target.transform.position;

		// Instantiate the Buff
		GameObject GO;
		GO = GameObject.Instantiate (particleSystem [0], playerbuffed, particleSystem [0].transform.rotation) as GameObject;




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
