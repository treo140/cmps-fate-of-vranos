using UnityEngine;
using System.Collections;

public class GamblingStrikes : BaseAbility {
	
	public void GamblingStrikesAbility(){
		AbilityName = "Gambling Strikes";
		AbilityDescription = "The Assassin unleashes a volley of strikes that can range from 1 to 10.";
		AbilityType = 1;
		AbilityTier = 4; 
		FocusCost = 10;
		SkillPointCost = 1;
	
	}
	
}
