using UnityEngine;
using System.Collections;

public class Wizard : BaseCharacterClass {
	
	public void WizardClass(){
		
		ClassName = "Wizard";
		ClassDescription = "Arcane character with the highest focus out of all characters.";
		Health = 40;
		Focus = 100;
		Resistance = 5;
		Speed = 40;
		SkillSet1 = new Elementalist();
		SkillSet2 = new Naturalist ();
		SkillSet3 = new TimeMender (); 
	}
}
