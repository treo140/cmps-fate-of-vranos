using UnityEngine;
using System.Collections;

public class SmokeBomb : BaseAbility {
	
	public void SmokeBombAbility(){
		AbilityName = "Smoke Bomb";
		AbilityDescription = "The Assassin throws a smoke bomb at the enemy, lowering their damage.";
		AbilityType = 1;
		AbilityTier = 3; 
	}
	
}
