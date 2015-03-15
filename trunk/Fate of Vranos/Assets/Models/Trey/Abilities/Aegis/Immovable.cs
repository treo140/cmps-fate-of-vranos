using UnityEngine;
using System.Collections;

public class Immovable : BaseAbility {
	
	public void ImmovableAbility(){
		AbilityName = "Immovable";
		AbilityDescription = "The Aegis is now more resistant to all status effects.";
		AbilityType = 0;
		AbilityTier = 4; 
	}
	
}
