using UnityEngine;
using System.Collections;

public class HotorCold : BaseAbility {

	public void HotOrColdAbility(){
		AbilityName = "Hot or Cold";
		AbilityDescription = "A weak magical attack that deals either fire or ice DMG, whichever is stronger against the enemy.";
		AbilityType = 1;
		AbilityTier = 1; 
	}

}
