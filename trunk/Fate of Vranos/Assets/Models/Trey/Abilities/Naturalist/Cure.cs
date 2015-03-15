using UnityEngine;
using System.Collections;

public class Cure : BaseAbility {
	
	public void CureAbility(){
		AbilityName = "Cure";
		AbilityDescription = "Cure selected party member of status effect.";
		AbilityType = 1;
		AbilityTier = 2; 
	}
	
}