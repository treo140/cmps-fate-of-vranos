using UnityEngine;
using System.Collections;

public class TimeMender : BaseSkillSet {
	
	public void TimeMenderSkillSet(){
		SkillSetName = "Time Mender";
		SkillSetDescription = "Time Menders, while bound by certain rules that prevent any serious damage to the space-time continuum, are still able to use there powers in a great capacity to help their allies from certain doom.";
		Abilities [0] = new Rocket();
		Abilities [1] = new ChronoTuner();
		Abilities [2] = new Overclock();
		Abilities [3] = new RocketSalvo();
		Abilities [4] = new Slow();
		Abilities [5] = new KYTE();
		Abilities [6] = new Rewind();
		Abilities [7] = new Blackhole();
	}
}
