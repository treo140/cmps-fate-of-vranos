using UnityEngine;
using System.Collections;

public class WaterBomb : BaseAbility {
	
	public void WaterBombAbility(){
		AbilityName = "Water Bomb";
		AbilityDescription = "Toss a water bomb that drenches the enemy.";
		AbilityType = 1;
		AbilityTier = 3; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
