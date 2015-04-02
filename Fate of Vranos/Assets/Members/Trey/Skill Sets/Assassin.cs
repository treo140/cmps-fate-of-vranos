using UnityEngine;
using System.Collections;

public class Assassin : BaseSkillSet {
	
	public void AssassinSkillSet(){
		SkillSetName = "Assassin";
		SkillSetDescription = "The Assassin strikes from the shadows without fear or missing a step.";
		Abilities [0] = new Backstab();
		Abilities [1] = new NinjaStep();
		Abilities [2] = new KnifeExpert();
		Abilities [3] = new SmokeBomb();
		Abilities [4] = new WeakPoints();
		Abilities [5] = new WindWalk();
		Abilities [6] = new GamblingStrikes();
		Abilities [7] = new BladeStorm();
	}
}

