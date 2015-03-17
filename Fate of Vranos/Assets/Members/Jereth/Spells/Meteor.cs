using UnityEngine;
using System.Collections;

public class Meteor : Spell {



	public Meteor(string name, string description, float damage, int cost, SpellEffect effect, GameObject GO, GameObject Platform, TargetType tar)
	{
		Debug.Log (Platform.name);
		Debug.Log (GO.name);
		Name = name;
		Description = description;
		Damage = damage;
		Cost = cost;
		Effect = effect;
		particleSystem = GO;
		platform = Platform;
		tarType = tar;
		//GameObject g = GameObject.Find ("LazyLoadBehaviour");
		//Debug.Log (g.name);
		particleSystem.SetActive (true);
		SetRandomStartPoint randStart = GO.GetComponentInChildren<SetRandomStartPoint> ();
		//SetRandomStartPoint r = particleSystem.GetComponent<SetRandomStartPoint> ();
		randStart.StartPointGo = Platform;
		particleSystem.SetActive (false);
		
	}

	public override void Cast (Transform target)
	{
		SetTarget (target);
		particleSystem.SetActive (true);

	}

	public override void Cast (){}
	public override void Cast (Transform[] targets){}

	public override void Animate ()
	{


		//throw new System.NotImplementedException ();
	}

	public override void doDamage ()
	{
		//throw new System.NotImplementedException ();
	}

	private void SetTarget(Transform target)
	{	
		//particleSystem.SetActive (true);
		particleSystem.transform.position = new Vector3 (target.transform.position.x, (target.transform.position.y + 10),
		                                                 target.transform.position.z);
		//particleSystem.SetActive (false);
		EffectSettings eSettings = particleSystem.GetComponent<EffectSettings> ();
		eSettings.Target = target.gameObject;
	}


}
