using UnityEngine;
using System.Collections;

public class ChooseSpells : MonoBehaviour {
	public UIGrid grid;
	public GameObject firebutton;
	public GameObject holybutton;
	public GameObject thunderbutton;
	public GameObject icebutton;
	public GameObject mudbutton;


	public GameObject player;
	public UILabel chooseSpellLabel;


	private PlayerBattleManager _playerbattlemanager;

	private int spells = 0;

	private bool fire = false;
	private bool thunder = false;
	private bool holy = false;
	private bool ice = false;
	private bool mud = false;

	// Use this for initialization
	void Start () {
		//_playerbattlemanager = player.GetComponent<PlayerBattleManager> ();
		//grid.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ChoseFire(){
		if( fire == false){
			/*grid.enabled = true;
			//grid.AddChild (firebutton);
			NGUITools.AddChild(grid.gameObject, firebutton);
			grid.Reposition();
			grid.enabled = false;*/

			firebutton.SetActive(true);
			grid.Reposition();
			spells++;
			fire = true;
		}
		if (spells == 3) {
			StartBattle();
		}
	}

	public void ChoseThunder(){
		if( thunder == false){
			//grid.AddChild (thunderbutton);
			/*NGUITools.AddChild(grid.gameObject, thunderbutton);
			grid.Reposition();*/			
			thunderbutton.SetActive(true);
			grid.Reposition();
			spells++;
			thunder = true;
		}
		if (spells == 3) {
			StartBattle();
		}
	}

	public void ChoseHoly(){
		if( holy == false){
			//grid.AddChild (holybutton);
			/*NGUITools.AddChild(grid.gameObject, holybutton);
			grid.Reposition();*/			
			holybutton.SetActive(true);
			grid.Reposition();
			spells++;
			holy = true;
		}
		if (spells == 3) {
			StartBattle();
		}
	}
	
	public void ChoseIce(){
		if( ice == false){
			//grid.AddChild (holybutton);
			/*NGUITools.AddChild(grid.gameObject, holybutton);
			grid.Reposition();*/			
			icebutton.SetActive(true);
			grid.Reposition();
			spells++;
			ice = true;
		}
		if (spells == 3) {
			StartBattle();
		}
	}
	
	public void ChoseMud(){
		if( mud == false){
			//grid.AddChild (holybutton);
			/*NGUITools.AddChild(grid.gameObject, holybutton);
			grid.Reposition();*/			
			mudbutton.SetActive(true);
			grid.Reposition();
			spells++;
			mud = true;
		}
		if (spells == 3) {
			StartBattle();
		}
	}
	public void StartBattle(){
		gameObject.SetActive(false);
		chooseSpellLabel.gameObject.SetActive(false);
		grid.enabled = true;

		
		/*firebutton.SetActive(false);	
		thunderbutton.SetActive(false);	
		holybutton.SetActive(false);	
		icebutton.SetActive(false);	
		mudbutton.SetActive(false);*/

		spells = 0;
		fire = false;
		thunder = false;
		holy = false;
		mud = false;
		ice = false;
	}
}
