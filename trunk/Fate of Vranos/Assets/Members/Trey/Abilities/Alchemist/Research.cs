using UnityEngine;
using System.Collections;

public class Research : BaseAbility {
	
	public void ResearchAbility(){
		AbilityName = "Research";
		AbilityDescription = "Further studies have given a greater understanding of all chemicals, increasing all stat boosts.";
		AbilityType = 0;
		AbilityTier = 3; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}

