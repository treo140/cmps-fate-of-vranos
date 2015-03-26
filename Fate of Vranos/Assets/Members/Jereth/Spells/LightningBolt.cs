using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LightningBolt : Spell {


	LightningBolt(string name, string description, float damage, int cost, SpellEffect effect, GameObject pSystem)
	{

		Name = name;
		Description = description;
		Damage = damage;
		Cost = cost;
		Effect = effect;
		particleSystem = pSystem;

	}

	public override void Cast (GameObject target)
	{
		throw new System.NotImplementedException ();
	}

	
	public override void Cast (){}
	public override void Cast (List<GameObject> targets){}

	public override void Animate ()
	{
		throw new System.NotImplementedException ();
	}

	public override void doDamage ()
	{
		throw new System.NotImplementedException ();
	}

}
