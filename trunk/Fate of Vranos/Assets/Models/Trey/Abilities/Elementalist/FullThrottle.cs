using UnityEngine;
using System.Collections;

public class FullThrottle : BaseAbility {
	
	public void FullThrottleAbility(){
		AbilityName = "Full Throttle";
		AbilityDescription = "Ignites the fire in all party members for faster attacks";
		AbilityType = 1;
		AbilityTier = 3; 
	}
	
}
