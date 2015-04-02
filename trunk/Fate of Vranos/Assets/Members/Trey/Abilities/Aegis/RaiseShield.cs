using UnityEngine;
using System.Collections;

public class RaiseShield : BaseAbility {
	
	public void RaiseShieldAbility(){
		AbilityName = "Raise Shield";
		AbilityDescription = "The Aegis raises his/her shield to greatly increase the defense of the party.";
		AbilityType = 1;
		AbilityTier = 4; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
