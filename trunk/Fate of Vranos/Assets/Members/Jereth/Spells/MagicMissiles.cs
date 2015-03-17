using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MagicMissiles : Spell {

	MagicMissiles (string name, string description, float damage, int cost, SpellEffect effect)
	{
		Name = name;
		Description = description;
		Damage = damage;
		Cost = cost;
		Effect = effect;
	}
	
	public override void Cast (Transform target)
	{
		//Magic Missiles have three missiles that fly to the target at the same time.
		//Each missile does its own damage and a powered up version has more than one set of three.

	}
	
	public override void Cast (){}
	public override void Cast (List<Transform> targets){}

	public override void Animate ()
	{
		//Prefab is called "Rocket1"

	}

	public override void doDamage ()
	{

	}
	
}
