using UnityEngine;
using System.Collections;

public class PackMaster : BaseSkillSet {
	
	public void PackMasterSkillSet(){
		SkillSetName = "Pack Master";
		SkillSetDescription = "*Howl* *Bark* *Howl* *Moo*' - Ancient Pack Master Proverb";
		Abilities [0] = new Arrow();
		Abilities [1] = new BestialBond();
		Abilities [2] = new SummonWolf();
		Abilities [3] = new AdvancedTamingMethods();
		Abilities [4] = new Howl();
		Abilities [5] = new SummonGorilla();
		Abilities [6] = new Trap();
		Abilities [7] = new SummonDragon();
	}
}
