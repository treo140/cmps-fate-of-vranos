using UnityEngine;
using System.Collections;

public class EnemyEntity {
	
	private string enemyName;
	private int health;							//Enemy's total health during a fight; if it reaches 0, that enemy is dead.
	private int focus;							//Enemy's total focus points for carrying out special attacks.
	private int resistance;						//Enemies damage protection.
	private int speed; 							//The time it takes a character til they can next perform an action
	//private elemental element;				//The Enemy's associated elemental type

	public string EnemyName{
		get {return enemyName;}
		set {enemyName = value;}
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

	//public int Speed{
	//	get {return speed;}
	//	set {speed = value;}
	//}

}