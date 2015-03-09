using UnityEngine;
using System.Collections;

public interface BaseSpell {

	string Name { get; set;}
	string Description { get; set; }
	float SpellDamage { get; set; }
	GameObject SpellAnim { get; set; }
	int Cooldown { get; set; }
	int TurnsLeft{ get; set; }
	Transform Target { get; set; }
	ParticleSystem MySpell { get; set; }
	

	void Cast(Transform target);

}
