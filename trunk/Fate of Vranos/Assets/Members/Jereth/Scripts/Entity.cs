using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Entity:MonoBehaviour {
	float attack;
	float defense;
	float health;
	public int speed;
	int charge;
	public float currentHealth;
	public List<Spell> knownSpells = new List<Spell>();

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
