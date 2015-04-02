using UnityEngine;
using System.Collections;

public class Aegis : BaseSkillSet {
	
	public void AegisSkillSet(){
		SkillSetName = "Aegis";
		SkillSetDescription = "Defend the homies.";
		Abilities [1] = new ShieldBash();
		Abilities [2] = new Bodyguard();
		Abilities [3] = new ThickPlating();
		Abilities [4] = new Taunt();
		Abilities [5] = new ThickSkin();
		Abilities [6] = new RaiseShield();
		Abilities [7] = new Immovable();
		Abilities [8] = new ServeAndProtect();

	}
}
