using UnityEngine;
using System.Collections;

public class WeakPoints : BaseAbility {
	
	public void WeakPointsAbility(){
		AbilityName = "Weak Points";
		AbilityDescription = "The assassin is able to point out flaws in the enemies defense, thereby lowering it.";
		AbilityType = 1;
		AbilityTier = 3;
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
