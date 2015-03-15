using UnityEngine;
using System.Collections;

public class TimeMender : BaseSkillSet {
	
	public void TimeMenderSkillSet(){
		SkillSetName = "Time Mender";
		SkillSetDescription = "Time Menders, while bound by certain rules that prevent any serious damage to the space-time continuum, are still able to use there powers in a great capacity to help their allies from certain doom.";
		Abilities [0] = new ShieldBash();
		Abilities [1] = new Bodyguard();
		Abilities [2] = new ThickPlating();
		Abilities [3] = new Taunt();
		Abilities [4] = new ThickSkin();
		Abilities [5] = new RaiseShield();
		Abilities [6] = new Immovable();
		Abilities [7] = new ServeAndProtect();
	}
}
