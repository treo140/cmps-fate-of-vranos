using UnityEngine;
using System.Collections;

public class PackMaster : BaseSkillSet {
	
	public void PackMasterSkillSet(){
		SkillSetName = "Pack Master";
		SkillSetDescription = "*Howl* *Bark* *Howl* *Howl - Ancient Pack Master Proverb";
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
