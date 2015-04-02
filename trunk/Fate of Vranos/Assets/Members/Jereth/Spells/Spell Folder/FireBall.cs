using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class FireBall : Spell 
{

	public FireBall(float damage, int cost, SpellEffect effect, Dictionary<string, GameObject> Spells,
	                GameObject caster)
	{

		Name = "Fireball";
		Description = "Throw a ball of fire magic at your enemy! Doing this may leave a burn.";
		Damage = damage;
		Cost = cost;
		Effect = effect;
		particleSystem = new List<GameObject> ();
		particleSystem.Add (Spells ["Red Fireball"]);
		particleSystem.Add (Spells ["Burn"]);
		platform = GameObject.Find("Spell Transform");
		tarType = TargetType.SingleEnemy;
		Caster = caster;

	}


	public override void Cast ()
	{
		//throw new System.NotImplementedException ();
	}

	public override void Cast (GameObject target)
	{

		// Reference to the Caster's position
		Vector3 cast = Caster.transform.position;

		// Reference the target's position
		Vector3 spellTar = target.transform.parent.position;

		// Instantiate the Fireball
		GameObject GO;
		GO = GameObject.Instantiate (particleSystem [0], cast , particleSystem [0].transform.rotation) as GameObject;
		GO.transform.position = cast;

		// Give the Fireball a target
		EffectSettings eSet = GO.GetComponent<EffectSettings> ();
		eSet.Target = target;



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
