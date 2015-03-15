using UnityEngine;
using System.Collections;

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

	public override void Cast (Transform target)
	{
		throw new System.NotImplementedException ();
	}

	public override void Animate ()
	{
		throw new System.NotImplementedException ();
	}

	public override void doDamage ()
	{
		throw new System.NotImplementedException ();
	}

}
