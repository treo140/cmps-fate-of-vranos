using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Meteor : Spell {



	public Meteor(string name, string description, float damage, int cost,
	              SpellEffect effect, GameObject GO, GameObject Platform, TargetType tar,
	              GameObject caster)
	{
		Debug.Log (Platform.name);
		Debug.Log (GO.name);
		Name = name;
		Description = description;
		Damage = damage;
		Cost = cost;
		Effect = effect;
		particleSystem = GO;
		particleSystem.SetActive (false);
		platform = Platform;
		tarType = tar;
		Caster = caster;

		particleSystem.SetActive (false);
		
	}

<<<<<<< .mine
	public override void Cast (GameObject target)
=======
	public override void Cast (GameObject[] target)
>>>>>>> .r9
	{
		particleSystem.transform.position = particleSystem.transform.parent.position;
		SetTarget (target[0]);
		particleSystem.SetActive (true);

	}

	public override void Cast (){}
	public override void Cast (List<GameObject> targets){}

	public override void Cast(GameObject target)
	{

	}

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
		//EffectSettings eSettings = particleSystem.GetComponent<EffectSettings> ();
		//eSettings.Target = target;
		particleSystem.SetActive (false);
	}

	public void StopAnimation()
	{
		MoveOnGround isFinished;
		isFinished = particleSystem.GetComponentInChildren<MoveOnGround> ();
		if (!isFinished.isFinished)
						particleSystem.SetActive (false);
	}

	/*public void pDestroy()
	{
		Destroy (particleSystem);
	}*/

}
