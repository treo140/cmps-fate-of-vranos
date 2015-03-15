using UnityEngine;
using System.Collections;

public class BaseCharacterClass {
	
	private string className;					//Name of the class.
	private string classDescription;            //Description of class and its associated skill trees and abilities.
	private int health;							//Character's total health during a fight; if it reaches 0, that character is KO'd.
	private int focus;							//Character's total focus points for carrying out special attacks.
	private int resistance;						//Character's protection from enemy damage.
	private int speed; 							//The time it takes a character til they can next perform an action

	private BaseSkillSet skillSet1;				//Which group of skills the class has access to.
	private BaseSkillSet skillSet2;				//skillSet1 = 1 for Warriors, = 4 for Wizards, = 7 for Rogues and so on.
	private BaseSkillSet skillSet3;				//Jack of All Trades have one skill set from each class (Ex. skillSet1 = 1, skillSet2 = 5, skillSet3 = 9)


	public string ClassName{
		get {return className;}
		set {className = value;}
	}

	public string ClassDescription{
		get {return classDescription;}
		set {classDescription = value;}
	}

	public int Health{
		get {return health;}
		set {health = value;}
	}
	
	public int Focus{
		get {return focus;}
		set {focus = value;}
	}
	
	public int Resistance{
		get {return resistance;}
		set {resistance = value;}
	}
	
	public int Speed{
		get {return speed;}
		set {speed = value;}
	}
	

	public BaseSkillSet SkillSet1{
		get {return skillSet1;}
		set {skillSet1 = value;}
	}

	public BaseSkillSet SkillSet2{
		get {return skillSet2;}
		set {skillSet2 = value;}
	}

	public BaseSkillSet SkillSet3{
		get {return skillSet3;}
		set {skillSet3 = value;}
	}


}





















