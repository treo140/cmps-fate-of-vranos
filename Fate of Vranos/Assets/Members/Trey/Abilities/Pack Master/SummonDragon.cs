using UnityEngine;
using System.Collections;

public class SummonDragon :  BaseAbility {
	
	public void SummonDragonAbility(){
		AbilityName = "SummonDragon";
		AbilityDescription = "Summon the all-powerful Dragon to crush your foes.";
		AbilityType = 1;
		AbilityTier = 5; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}