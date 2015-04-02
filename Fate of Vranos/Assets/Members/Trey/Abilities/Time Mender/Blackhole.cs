using UnityEngine;
using System.Collections;

public class Blackhole : BaseAbility {
	
	public void BlackholeAbility(){
		AbilityName = "Blackhole";
		AbilityDescription = "Summon the crushing power of a blackhole to devestate your enemies.";
		AbilityType = 1;
		AbilityTier = 5; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}

