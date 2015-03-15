using UnityEngine;
using System.Collections;

public class Alchemist : BaseSkillSet {
	
	public void AlchemistSkillSet(){
		SkillSetName = "Alchemist";
		SkillSetDescription = "In terms of weaking enemies and strengthening allies with science, the Alchemist has no equal in battle.";
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

