using UnityEngine;
using System.Collections;

public class Elementalist : BaseSkillSet {
	
	public void ElementalistSkillSet(){
		SkillSetName = "Elementalist";
		SkillSetDescription = "By tapping into two of the most powerful elements in Vranos, elementalist are able to cause mass destruction with the snap of their fingers.";
		Abilities [0] = new HotorCold();
		Abilities [1] = new FireWithin();
		Abilities [2] = new FrostShield();
		Abilities [3] = new FullThrottle();
		Abilities [4] = new IceDome();
		Abilities [5] = new Fireball();
		Abilities [6] = new Blizzard();
		Abilities [7] = new ElementalFury();
	}
}

