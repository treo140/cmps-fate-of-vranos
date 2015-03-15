using UnityEngine;
using System.Collections;

public class IceDome : BaseAbility {
	
	public void IceDomeAbility(){
		AbilityName = "Ice Dome";
		AbilityDescription = "Encases the party in a protect ice dome, which greatly increases defense and has a chance to freeze any enemy that touches it.";
		AbilityType = 1;
		AbilityTier = 3; 
	}
	
}
