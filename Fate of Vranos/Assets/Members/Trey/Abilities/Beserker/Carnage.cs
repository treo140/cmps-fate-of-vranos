using UnityEngine;
using System.Collections;

public class Carnage :  BaseAbility {
	
	public void CarnageAbility(){
		AbilityName = "Carnage";
		AbilityDescription = "Attack an enemy and restore a portion of your lost health with theirs.";
		AbilityType = 1;
		AbilityTier = 4; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}