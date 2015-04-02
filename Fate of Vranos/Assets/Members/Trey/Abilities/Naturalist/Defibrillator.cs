using UnityEngine;
using System.Collections;

public class Defibrillator : BaseAbility {
	
	public void DefibrillatorAbility(){
		AbilityName = "Defibrillator";
		AbilityDescription = "Shocks a KO'd party member back into the fight.";
		AbilityType = 1;
		AbilityTier = 3; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
