using UnityEngine;
using System.Collections;

public class SpellCollisionBehaviour : MonoBehaviour {

	public GameObject target;
	public EffectSettings eSet;
	public bool isInit = false;


	// Use this for initialization
	void Start () 
	{


	}
	
	// Update is called once per frame
	void Update () 
	{

		if (!isInit)
						return;

		// reference to the spell to aquire which buff to apply


		// apply the buff/debuff to the target
	
	}

	public void Initialize()
	{

		eSet = gameObject.GetComponent<EffectSettings> ();
		target = eSet.Target;

		isInit = true;


	}

}
