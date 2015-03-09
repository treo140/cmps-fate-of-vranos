using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerStats : MonoBehaviour {
	
	public float totalHealth;
	public float currentHealth;
	public float attack;

	public string name;
	public string description;
	
	public int maxCharge;
	public int initCharge;
	public int speed;

	public bool ally;
	public int missionNumber;

	public List<PlayerStats> Allies;

	void Start() {
		currentHealth = totalHealth;
		//Messenger.AddListener("endBattle", EndBattle);
	}

	public void AddHealth(float amount)
	{
		Debug.Log ("Healing for " + amount);
		// check if player is missing any health
		if (currentHealth < totalHealth) 
		{
			Debug.Log("Before Heal: " + currentHealth);
			currentHealth += amount; // player's current health increases by the amount passed
			Debug.Log("After Heal: " + currentHealth);
		}
		Debug.Log ("Checking if player has too much health");
		// check if player currently has more health than its maximum
		if (currentHealth >= totalHealth) 
		{
			Debug.Log("Yes!");
			currentHealth = totalHealth; // player's current health will equal his max health
			return;
		}

		Debug.Log ("No!");
		return;

	}

	public void TakeDamage(float damageTaken) {
		
		Debug.Log ("Ouch! I took damage!");
		currentHealth = currentHealth - damageTaken;

		
	}

	public void AddAlly(PlayerStats allySats){
		if (Allies.Count < 2) {
			Allies.Add(allySats);
		}
	}
}
