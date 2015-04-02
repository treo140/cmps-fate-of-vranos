using UnityEngine;
using System.Collections;

public class SummonGorilla :  BaseAbility {
	
	public void SummmonGorillaAbility(){
		AbilityName = "Summon Gorilla";
		AbilityDescription = "Summon the mighty Gorilla to soak up an incredible amount of pain.";
		AbilityType = 1;
		AbilityTier = 4; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}