using UnityEngine;
using System.Collections;

public class Naturalist : BaseSkillSet {
	
	public void NaturalistSkillSet(){
		SkillSetName = "Naturalist";
		SkillSetDescription = "Whether its the plants of the surface or the lightning in the sky, the Naturalist is never truly vulnerable to the forces opposing all life";
		Abilities [0] = new Shock();
		Abilities [1] = new HealingRoots();
		Abilities [2] = new Cure();
		Abilities [3] = new EyeoftheStorm();
		Abilities [4] = new NaturesEmbrace();
		Abilities [5] = new Defibrillator();
		Abilities [6] = new NaturesSavior();
		Abilities [7] = new LightningStorm();
		
	}
}

