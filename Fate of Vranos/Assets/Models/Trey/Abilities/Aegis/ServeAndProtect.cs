using UnityEngine;
using System.Collections;

public class ServeAndProtect : BaseAbility {
	
	public void ServeAndProtectAbility(){
		AbilityName = "Serve and Protect";
		AbilityDescription = "In the ultimate act of sacrifice, the Aegis blocks all incoming damage to the party for 3 turns, but only recieves half that amount.";
		AbilityType = 1;
		AbilityTier = 5; 
	}
	
}
