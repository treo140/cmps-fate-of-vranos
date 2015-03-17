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
	public GameObject particleSystem;
	public GameObject platform;
	public TargetType tarType;

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

	public Spell(string name, string description, float damage, int cost, GameObject pSystem)
	{
		Name = name;
		Description = description;
		Damage = damage;
		Cost = cost;
		particleSystem = pSystem;
		Effect = SpellEffect.none;
	}

	public Spell(string name, string description, float damage, int cost, SpellEffect effect, GameObject pSystem, GameObject Platform, TargetType tar)
	{
		Name = name;
		Description = description;
		Damage = damage;
		Cost = cost;
		Effect = effect;
		particleSystem = pSystem;
		platform = Platform;

	}

	abstract public void Cast();
	abstract public void Cast(Transform target);
	abstract public void Cast(List<Transform> targets);
	abstract public void Animate();
	abstract public void doDamage();

}
