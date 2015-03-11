using UnityEngine;
using System.Collections;

public class FateOfVranos : BaseSpell {

	private string _name;
	private string _description;
	private GameObject _spell;
	private int _cooldown;
	private int _turnsLeft;
	private Transform _target;
	private ParticleSystem _particleSystem;

	
	private float _spellDamage;
	
	public FateOfVranos() {
		
		//GameObject Effect{ get; set; }
		Name = "Fate of Vranos";
		Description = "You think Mages are OP, just wait until you see this.";
		SpellAnim = GameObject.Find ("Fate of Vranos");
		SpellDamage = 1000f;
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

	public Transform Target {
		get {
			return _target;
		}
		set {
			_target = value;
		}
	}
	
	public ParticleSystem MySpell {
		get {
			return _particleSystem;
		}
		set {
			_particleSystem = value;
		}
	}


	public void Cast (Transform target)
	{
		_spell.gameObject.transform.LookAt (_target);
		_spell.gameObject.particleSystem.Play ();
		AudioSource _audio = _spell.gameObject.particleSystem.GetComponent<AudioSource> ();
		_audio.Play();
		//throw new System.NotImplementedException ();
	}

	
	#endregion
	
}