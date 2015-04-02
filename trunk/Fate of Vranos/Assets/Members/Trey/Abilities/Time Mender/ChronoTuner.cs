using UnityEngine;
using System.Collections;

public class ChronoTuner : BaseAbility {
	
	public void ChronoTunerAbility(){
		AbilityName = "Chrono Tuner";
		AbilityDescription = "Increase attack by becoming more in tune with future tech.";
		AbilityType = 0;
		AbilityTier = 2;
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
