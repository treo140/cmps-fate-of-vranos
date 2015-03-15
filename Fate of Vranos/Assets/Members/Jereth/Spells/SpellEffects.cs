using UnityEngine;
using System.Collections;

public enum SpellEffect
{
	// These enum will be used to make DoTs, HoTs, Buffs, and Debuffs work.
	// Think of this as putting a state machine into a spell.
	// An object of class Spell will have a SpellEffect member in it to determine if that spell currently 
	// has an effect. If there is no current effect(i.e. spell gains an effect after a specific talent in
	// skill tree has been chosen) then the SpellEffect will be set to the state "none".
	none,
	stun,
	paralyze,
	freeze,
	burn,
	asleep,
	soaked, // Soaked is used for being soaked in something like water.
	drenched, // Drenched is used for being drenched in something like gasoline.
	bleeding,
	moreDef,
	moreAtt,
	moreSpd,
	lessDef,
	lessAtt,
	lessSpd

}
