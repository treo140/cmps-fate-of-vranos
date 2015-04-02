using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Entity : MonoBehaviour {
	public float attack;
	public float defense;
	public float health;
	public int speed;
	public int charge;
	public float currentHealth;
	public List<Spell> knownSpells = new List<Spell>();
	public GameObject model;
	public List<Entity> Allies = new List<Entity>();
	public int currentCharge;


	public Entity()
	{
		attack = 1;
		defense = 1;
		health = 1;
		speed = 1;
		charge = 1;
		currentHealth = 1;
		currentCharge = 0;

	}

	public void AddAlly (Entity a)
	{
		Allies.Add (a);
	}

	public void SetModel (GameObject a)
	{
		model = a;
	}

	public void PopulateSpellBook ()
	{

	}

	public void AddSpell (Spell a)
	{
		knownSpells.Add (a);
	}



}
