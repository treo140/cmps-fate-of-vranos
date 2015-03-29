using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Spell
{
	public string Name;
	public string Description;
	public float Damage;
	public int Cost;
	public SpellEffect Effect;
	public List<GameObject> particleSystem;
	public GameObject platform;
	public TargetType tarType;
	public GameObject Caster;

	public Spell()
	{
		Name = "Spell";
		Description = "Spell Description";
		Damage = 1;
		Cost = 1;
		particleSystem = null;
		Effect = SpellEffect.none;
		platform = null;


	}

	public Spell(float damage, int cost, GameObject pSystem)
	{
		Name = "Spell";
		Description = "Spell Description";
		Damage = damage;
		Cost = cost;
		//particleSystem = pSystem;
		Effect = SpellEffect.none;
	}

	public Spell(float damage, int cost, SpellEffect effect, Dictionary<string, GameObject> Spells,
	             GameObject Platform, TargetType tar,
	             GameObject caster)
	{
		Name = "Spell";
		Description = "Spell Description";
		Damage = damage;
		Cost = cost;
		Effect = effect;
		//particleSystem = pSystem;
		platform = Platform;
		Caster = caster;

	}

	abstract public void Cast();
	abstract public void Cast(GameObject target);
	abstract public void Cast(List<GameObject> targets);
	abstract public void Animate();
	abstract public void doDamage();

}
