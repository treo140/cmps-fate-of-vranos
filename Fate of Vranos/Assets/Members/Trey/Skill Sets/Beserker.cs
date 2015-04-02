using UnityEngine;
using System.Collections;

public class Beserker : BaseSkillSet {
	
	public void BeserkerSkillSet(){
		SkillSetName = "Beserker";
		SkillSetDescription = "'What is that red blur over the hill?' - Last words of evil doer- Give into the anger within and unleash your rage on the party's foes.";
		Abilities [0] = new Smash();
		Abilities [1] = new Rage();
		Abilities [2] = new InnerFury();
		Abilities [3] = new ComeAtME();
		Abilities [4] = new OneWithTheBlood();
		Abilities [5] = new Carnage();
		Abilities [6] = new Reave();
		Abilities [7] = new SpreadTheMadness();

	}
}
