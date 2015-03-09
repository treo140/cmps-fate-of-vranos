using UnityEngine;
using System.Collections;

public class UIToolTip : MonoBehaviour {
	public UILabel description;

	//public UITooltip tooltip;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnHover(bool isOver){
		if (isOver) {
						if (gameObject.name == "fireball_button")
								description.text = new Fireball ().Description + " Cooldown:" + new Fireball ().Cooldown;
						else if (gameObject.name == "thunderstrike_button")
								description.text = new ThunderStrike ().Description + " Cooldown:" + new ThunderStrike ().Cooldown;
						else if (gameObject.name == "holystrike_button")
								description.text = new HolyStrike ().Description + " Cooldown:" + new HolyStrike ().Cooldown;
						else if (gameObject.name == "iceball_button")
								description.text = new Iceball ().Description + " Cooldown:" + new Iceball ().Cooldown;
						else if (gameObject.name == "mudball_button")
								description.text = new Mudball ().Description + " Cooldown:" + new Mudball ().Cooldown;

						//print ("FIREBALL BETCH");
				} else {
						if (description.gameObject.name == "TooltipChoose")
								description.text = "Choose 3 spells";
						else
								description.text = "";
				}
	}
}
