using UnityEngine;
using System.Collections;

public abstract class Entity {
	float attack;
	float defense;
	float health;
	public int speed;
	int charge;
	public float currentHealth;

	Entity()
	{
		attack = 1;
		defense = 1;
		health = 1;
		speed = 1;
		charge = 1;
		currentHealth = 1;

	}

}
