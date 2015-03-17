using UnityEngine;
using System.Collections;

public class SpellTest : MonoBehaviour {

	public GameObject[] prefab;
	public Spell meteor;
	public GameObject target;
	public EffectSettings effectSettings;
	public GameObject GO;
	public GameObject platform;

	// Use this for initialization
	void Start () 
	{
		//meteor = new Meteor ("Meteor", "Flying Rock", 50f, 1, SpellEffect.none, prefab[0]);
		//GO = Instantiate(prefab[0], prefab[0].transform.position, prefab[0].transform.rotation) as GameObject;

		//GO.SetActive (false);

		InstanceObject();

	}

	void Awake ()
	{
	  /*  meteor = new Meteor ("Meteor", "Flying Rock", 50f, 1, SpellEffect.none, GO);
		effectSettings = prefab[0].GetComponent<EffectSettings> ();
		effectSettings.Target = target;
		*/
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.J)) 
		{
			//effectSettings.OnEnable();

			GO.transform.position = new Vector3(target.transform.position.x, (target.transform.position.y + 10),
			                                    target.transform.position.z);
			meteor.Cast (target.transform);
		}
	}

	public void InstanceObject()
	{
		target = GameObject.Find("_Aqua_Knight");
		platform = GameObject.Find("Top Platform");
		GO = Instantiate(prefab[0], new Vector3 (target.transform.position.x, (target.transform.position.y + 10f),
		                                                 target.transform.position.z), prefab[0].transform.rotation) as GameObject;
		//GO.SetActive (false);
		meteor = new Meteor ("Meteor", "Flying Rock", 50f, 1, SpellEffect.none, GO, platform, TargetType.SingleEnemies);
	}
}
