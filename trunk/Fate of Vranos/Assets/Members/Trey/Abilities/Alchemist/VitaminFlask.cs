using UnityEngine;
using System.Collections;

public class VitaminFlask : BaseAbility {
	
	public void VitaminFlaskAbility(){
		AbilityName = "Vitamin Flask";
		AbilityDescription = "Gives the selected character increased health and attack.";
		AbilityType = 1;
		AbilityTier = 2; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
