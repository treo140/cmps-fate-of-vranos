using UnityEngine;
using System.Collections;

public class Modifier {

	public float value = 1.0f;
	public SpellEffect modType = SpellEffect.none;
	public int duration = 0;
	public Entity modTarget;

	public Modifier(Entity modTarget){
		
	}

	public Modifier(float newValue, int newDuration, SpellEffect newType, Entity newTarget){
		value = newValue;
		duration = newDuration;
		modType = newType;
		modTarget = newTarget;
	}

	/*public void ExecuteBuffs(){
		foreach modifier in list of modifiers
		if modifier.duration > 0
			//execute modifier depending on type
			switch(modType):
			{
				case: SpellEffect.none
					break;
				case: SpellEffect.stun
					break;
				case: SpellEffect.paralyze
					break;
				case: SpellEffect.freeze
					break;
				case: SpellEffect.asleep
					break;
				case: SpellEffect.soaked // Soaked is used for being soaked in something like water.
					break;
				case: SpellEffect.drenched // Drenched is used for being drenched in something like gasoline.
					break;
				case: SpellEffect.burn
					currentHealth -= modifier.value;
				case: SpellEffect.bleeding
					break;
				case: SpellEffect.moreDef
				case: SpellEffect.lessDef
					currentDef *= modifier.value;
					break;
				case: SpellEffect.moreAtt
				case: SpellEffect.lessAtt
					currentAtk *= modifier.value;
					break;
				case: SpellEffect.moreSpd
				case: SpellEffect.lessSpd
					currentSpeed*= modifier.value;
					break;
				Default:
					break;
			}

		modifier --;
		if modifier.duration <= 0
			remove modifier
	}*/
}
