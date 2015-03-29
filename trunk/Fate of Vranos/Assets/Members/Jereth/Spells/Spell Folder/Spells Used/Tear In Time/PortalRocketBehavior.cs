using UnityEngine;
using System.Collections;

public class PortalRocketBehavior : MonoBehaviour {

	// Use this for initialization
	void Start () {

		// Make a reference to the portal's effect setting's target
		EffectSettings eSetting = GetComponent<EffectSettings> ();
		EffectSettings ePSetting = GetComponentInParent<EffectSettings> ();
		
		eSetting.Target = ePSetting.Target;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnEnable()
	{
		// Make a reference to the portal's effect setting's target
		EffectSettings eSetting = GetComponent<EffectSettings> ();
		EffectSettings ePSetting = GetComponentInParent<EffectSettings> ();

		eSetting.Target = ePSetting.Target;

	}
}
