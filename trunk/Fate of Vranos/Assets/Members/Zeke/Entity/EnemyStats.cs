using UnityEngine;
using System.Collections;

public class EnemyStats : MonoBehaviour {

	public float totalHealth;
	public float attackDamage;
	private float currentHealth;
	public string name;
	public string description;
	public int speed;

	public int missionNumber;

	void Start() {
		currentHealth = totalHealth;
	}

	public float GetCurrentHealth() {
		return currentHealth;
	}
	
	public float GetTotalHealth() {
		return totalHealth;
	}

	public float GetAttackDamage() {
		return attackDamage;
	}

	public void TakeDamage(float damageTaken) {

		Debug.Log ("Ouch! I took damage!");
		currentHealth = currentHealth - damageTaken;

	}
}
