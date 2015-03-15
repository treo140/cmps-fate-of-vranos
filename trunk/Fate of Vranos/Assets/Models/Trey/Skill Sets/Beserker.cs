using UnityEngine;
using System.Collections;

public class Beserker : BaseSkillSet {
	
	public void BeserkerSkillSet(){
		SkillSetName = "Beserker";
		SkillSetDescription = "'What is that red blur over the hill?' - Last words of evil asshole- Give into the anger within and unleash your rage on the party's foes.";
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
