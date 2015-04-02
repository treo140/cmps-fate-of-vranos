using UnityEngine;
using System.Collections;

public class Rewind : BaseAbility {
	
	public void RewindAbility(){
		AbilityName = "Rewind";
		AbilityDescription = "Reset a player's turn";
		AbilityType = 1;
		AbilityTier = 4; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}

