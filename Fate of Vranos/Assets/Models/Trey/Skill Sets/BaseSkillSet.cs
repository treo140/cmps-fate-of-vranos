using UnityEngine;
using System.Collections;

public class BaseSkillSet {

	private string skillSetName;					//Name of the Skill Set
	private string skillSetDescription;				//Description of the Skill Set

	public BaseAbility[] abilities = new BaseAbility[10];

	public string SkillSetName{
		get {return skillSetName;}
		set {skillSetName = value;}
	}

	public string SkillSetDescription{
		get {return skillSetDescription;}
		set {skillSetDescription = value;}
	}

	public BaseAbility[]  Abilities{
		get {return abilities;}
		set {abilities = value;}
	}
	
}
