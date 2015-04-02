using UnityEngine;
using System.Collections;

public class JackofAllTrades : BaseCharacterClass {

	public void JackClass(){
		
		ClassName = "Jack of All Trades";
		ClassDescription = "A character whose stats and skills are completely random for every playthrough.";
		Health = Random.Range(50,80);
		Focus = Random.Range(50,80);
		Resistance = Random.Range(10,25);
		Speed = Random.Range(30,50);

		int i = 0;
		//Set the 1st Skill Set which is randomly taken from the warrior pool.
		i = Random.Range(1,3);
		if (i == 1) {
			SkillSet1 = new Aegis();
		}
		if (i == 2) {
			SkillSet1 = new Beserker();
		}
		else if (i == 3) {
			SkillSet1 = new Paladin();
		}

		//Set the 2nd Skill Set which is randomly taken from the wizard pool.
		i = Random.Range(4,6);
		if (i == 4) {
			SkillSet2 = new Elementalist();
		}
		else if (i == 5) {
			SkillSet2 = new Naturalist();
		}
		else if (i == 6) {
			SkillSet2 = new TimeMender();
		}

		//Set the 3rd Skill Set which is randomly taken from the rogue pool.
		i = Random.Range(1,3);
		if (i == 7) {
			SkillSet3 = new Alchemist();
		}
		else if (i == 8) {
			SkillSet3 = new Assassin();
		}
		else if (i == 9) {
			SkillSet3 = new PackMaster();
		}
	}
}

