using UnityEngine;
using System.Collections;

public class ChemicalZ : BaseAbility {
	
	public void ChemicalZAbility(){
		AbilityName = "Chemical Z";
		AbilityDescription = "Gives either a massive boost to stats or deals a massive amount of damage.";
		AbilityType = 1;
		AbilityTier = 5; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
