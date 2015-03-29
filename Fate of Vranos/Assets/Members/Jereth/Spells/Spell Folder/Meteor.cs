using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Meteor : Spell {



	public Meteor(float damage, int cost, SpellEffect effect, Dictionary<string, GameObject> Spells, 
	              GameObject Platform, TargetType tar,
	              GameObject caster)
	{

		Name = "Meteor";
		Description = "Giant rock falling from the sky!";
		Damage = damage;
		Cost = cost;
		Effect = effect;
		particleSystem = new List<GameObject> ();
		particleSystem.Add (Spells ["Meteor"]);
		platform = Platform;
		tarType = tar;
		Caster = caster;
		
	}

	public override void Cast (GameObject target)
	{
		particleSystem[0].transform.position = particleSystem[0].transform.parent.position;
		SetTarget (target);
		particleSystem[0].SetActive (true);

	}

	public override void Cast (){}
	public override void Cast (List<GameObject> targets){}

	public override void Animate ()
	{


		//throw new System.NotImplementedException ();
	}

	public override void doDamage ()
	{
		//throw new System.NotImplementedException ();
	}

	private void SetTarget(GameObject target)
	{	
		//particleSystem.SetActive (true);
		//particleSystem.transform.position = new Vector3 (target.transform.position.x, (target.transform.position.y + 10),
		//                                                 target.transform.position.z);
		//particleSystem.SetActive (false);
		EffectSettings eSettings = particleSystem[0].GetComponent<EffectSettings> ();
		eSettings.Target = target;
		particleSystem[0].SetActive (false);
	}

	public void StopAnimation()
	{
		MoveOnGround isFinished;
		isFinished = particleSystem[0].GetComponentInChildren<MoveOnGround> ();
		if (!isFinished.isFinished)
						particleSystem[0].SetActive (false);
	}

	/*public void pDestroy()
	{
		Destroy (particleSystem);
	}*/

}
