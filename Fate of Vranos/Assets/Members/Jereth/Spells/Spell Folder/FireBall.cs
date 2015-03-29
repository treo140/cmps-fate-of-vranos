using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FireBall : Spell 
{

	public FireBall(float damage, int cost, SpellEffect effect, Dictionary<string, GameObject> Spells, 
	                GameObject Platform, TargetType tar,
	                GameObject caster)
	{

		Name = "Fireball";
		Description = "Throw a ball of fire magic at your enemy! Doing this may leave";
		Damage = damage;
		Cost = cost;
		Effect = effect;
		particleSystem = new List<GameObject> ();
		particleSystem.Add (Spells ["Red Fireball"]);
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
		// Reference the target's position

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
