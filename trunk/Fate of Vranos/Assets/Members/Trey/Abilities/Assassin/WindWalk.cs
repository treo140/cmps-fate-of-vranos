using UnityEngine;
using System.Collections;

public class WindWalk : BaseAbility {
	
	public void WindWalkAbility(){
		AbilityName = "Wind Walk";
		AbilityDescription = "The assassin is able to dodge all enemy attacks for one turn.";
		AbilityType = 1;
		AbilityTier = 4; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
