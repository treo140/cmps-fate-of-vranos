using UnityEngine;
using System.Collections;

public class Overclock : BaseAbility {
	
	public void OverclockAbility(){
		AbilityName = "Overclock";
		AbilityDescription = "Increase speed of entire party";
		AbilityType = 1;
		AbilityTier = 2; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
