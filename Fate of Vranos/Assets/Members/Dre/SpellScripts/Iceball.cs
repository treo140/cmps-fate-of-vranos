using UnityEngine;
using System.Collections;

public class Iceball : BaseSpell {
	
	// Add a path to the effects folder
	
	private string _name;
	private string _description;
	private GameObject _spell;
	private int _cooldown;
	private int _turnsLeft;
	
	
	private float _spellDamage;
	
	public Iceball() {
		
		//GameObject Effect{ get; set; }
		Name = "Iceball";
		Description = "Lobs a Iceball at the enemy";
		SpellAnim = GameObject.Find ("Iceball");
		SpellDamage = 5f;
	}
	
	public Iceball(GameObject Caster) {
		
		//GameObject Effect{ get; set; }
		Name = "Iceball";
		Description = "Lobs a Iceball at the enemy";
		if(Caster.tag == "Enemy")
			SpellAnim = GameObject.Find ("IceballE");
		else
			SpellAnim = GameObject.Find ("Iceball");
		SpellDamage = 15f;
	}
	
	#region BaseSpell implementation
	
	public string Name {
		get {
			return _name;
			//throw new System.NotImplementedException ();
		}
		set {
			_name = value;
		}
	}
	public string Description {
		get {
			return _description;
			//throw new System.NotImplementedException ();
		}
		set {
			_description = value;
		}
	}
	
	public float SpellDamage {
		get {
			return _spellDamage;
			//throw new System.NotImplementedException ();
		}
		set {
			_spellDamage = value;
		}
	}
	
	public GameObject SpellAnim {
		get {
			return _spell;
			//throw new System.NotImplementedException ();
		}
		set {
			_spell = value;
			//throw new System.NotImplementedException ();
		}
	}

	public int Cooldown{
		get {
			return _cooldown;
			//throw new System.NotImplementedException ();
		}
		set {
			_cooldown = value;
			//throw new System.NotImplementedException ();
		}
	}
	
	public int TurnsLeft{
		get {
			return _turnsLeft;
			//throw new System.NotImplementedException ();
		}
		set {
			_turnsLeft = value;
			//throw new System.NotImplementedException ();
		}
	}

	public void Cast ()
	{
		_spell.gameObject.particleSystem.Play ();
		AudioSource _audio = _spell.gameObject.particleSystem.GetComponent<AudioSource> ();
		_audio.Play();
		//throw new System.NotImplementedException ();
	}
	
	#endregion
	
}
