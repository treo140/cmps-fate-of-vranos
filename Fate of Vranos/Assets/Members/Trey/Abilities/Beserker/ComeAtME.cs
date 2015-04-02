using UnityEngine;
using System.Collections;

public class ComeAtME : BaseAbility {
	
	public void ComeAtMEAbility(){
		AbilityName = "Come at ME";
		AbilityDescription = "The beserker's version of the taunt which increases his attack instead of defense.";
		AbilityType = 1;
		AbilityTier = 3; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
