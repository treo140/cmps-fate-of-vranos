using UnityEngine;
using System.Collections;

public class ChemicalX : BaseAbility {
	
	public void ChemicalXAbility(){
		AbilityName = "Chemical X";
		AbilityDescription = "Powerful potion which gives a random stat boost to the selected ally; don't let Profesor Plutonium anywhere.";
		AbilityType = 1;
		AbilityTier = 4; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}

