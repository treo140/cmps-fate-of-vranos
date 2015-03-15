using UnityEngine;
using System.Collections;

public class Blizzard : BaseAbility {
	
	public void BlizzardAbility(){
		AbilityName = "Blizzard";
		AbilityDescription = "Unleash a tundra on all enemies which also has a chance to freeze/slow.";
		AbilityType = 1;
		AbilityTier = 4; 
	}
	
}
