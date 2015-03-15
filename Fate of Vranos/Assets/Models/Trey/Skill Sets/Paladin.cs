using UnityEngine;
using System.Collections;

public class Paladin : BaseSkillSet {

	public void PaladinSkillSet(){
		SkillSetName = "Paladin";
		SkillSetDescription = "Combat the darkness with skills of one of the oldest and righteous orders in.";
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
