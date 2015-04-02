using UnityEngine;
using System.Collections;

public class SummonWolf :  BaseAbility {
	
	public void SummonWolfAbility(){
		AbilityName = "Summon Wolf";
		AbilityDescription = "Summon the loyal and ferocious wolf to combat your foes.";
		AbilityType = 1;
		AbilityTier = 2; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}