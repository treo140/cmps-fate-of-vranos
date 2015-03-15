using UnityEngine;
using System.Collections;

public class BaseAbility {

	private string abilityName;					//Name of the ability
	private string abilityDescription;			//Description of what the ability does
	private int abilityType;					//0 = Passive; 1 = Active
	private int abilityTier;					//Which Tier is the ability in(1-5)
	private int focusCost;						//Amount of focus the ability cost to use in battle
	private int skillPointCost;					//Skill points the ability costs to unlock in the skill tree


	public string AbilityName{
		get {return abilityName;}
		set {abilityName = value;}
	}
	
	public string AbilityDescription{
		get {return abilityDescription;}
		set {abilityDescription = value;}
	}
	
	public int AbilityType{
		get {return abilityType;}
		set {abilityType = value;}
	}

	public int AbilityTier{
		get {return abilityTier;}
		set {abilityTier = value;}
	}

	public int FocusCost{
		get {return focusCost;}
		set {focusCost = value;}
	}

	public int SkillPointCost{
		get {return skillPointCost;}
		set {skillPointCost = value;}
	}
	
}






