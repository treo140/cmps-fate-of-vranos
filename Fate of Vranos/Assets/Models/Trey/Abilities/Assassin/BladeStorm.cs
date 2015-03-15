using UnityEngine;
using System.Collections;

public class BladeStorm : BaseAbility {
	
	public void BladeStormAbility(){
		AbilityName = "Blade Storm";
		AbilityDescription = "The Ninja does critical damage and lowers the defenses of all enemies by a large amount.";
		AbilityType = 1;
		AbilityTier = 5; 
	}
	
}
