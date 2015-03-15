using UnityEngine;
using System.Collections;

public class Taunt : BaseAbility {
	
	public void TauntAbility(){
		AbilityName = "Taunt";
		AbilityDescription = "Redirect an enemy's aggression to protect the rest of the party";
		AbilityType = 1;
		AbilityTier = 3; 
	}
	
}
