using UnityEngine;
using System.Collections;

public class Alchemist : BaseSkillSet {
	
	public void AlchemistSkillSet(){
		SkillSetName = "Alchemist";
		SkillSetDescription = "In terms of weaking enemies and strengthening allies with science, the Alchemist has no equal in battle.";
		Abilities [1] = new Grenade();
		Abilities [2] = new OilBomb();
		Abilities [3] = new WaterBomb();
		Abilities [4] = new Research();
		Abilities [5] = new VitaminFlask();
		Abilities [6] = new ChemicalX();
		Abilities [7] = new ChemicalY();
		Abilities [8] = new ChemicalZ();
	}
}

