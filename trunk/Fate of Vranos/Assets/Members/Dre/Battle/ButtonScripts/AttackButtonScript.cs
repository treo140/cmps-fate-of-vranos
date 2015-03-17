using UnityEngine;
using System.Collections;

public class AttackButtonScript : MonoBehaviour {

	private BattleButtonManager buttonManager;
	private TurnManager turnManager;
	private UIButton thisButton;
	
	public Spell spell;


	// Use this for initialization
	void Start () {
		buttonManager = GameObject.FindGameObjectWithTag ("BattleButtonManager").GetComponent<BattleButtonManager>();
		turnManager = buttonManager.gameObject.GetComponent<TurnManager> ();
		thisButton = gameObject.GetComponent<UIButton>();
	}
	
	// Update is called once per frame
	void Update () {
		//thisButton.isEnabled = turnManager.tempCharge > spell.ChargeCost;
	}

	public void Clicked(){
		turnManager.addSpell (spell);

	}
}
