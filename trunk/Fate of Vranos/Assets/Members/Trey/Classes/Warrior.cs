using UnityEngine;
using System.Collections;

public class Warrior : BaseCharacterClass {

	public void WarriorClass(){
	
		ClassName = "Warrior";
		ClassDescription = "A powerful character who has high health and resistance to damage.";
		Health = 100;
		Focus = 30;
		Resistance = 30;
		Speed = 25;
		SkillSet1 = new Aegis();
		SkillSet2 = new Beserker();
		SkillSet3 = new Paladin();

	}
}
