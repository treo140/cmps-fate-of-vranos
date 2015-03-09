using UnityEngine;
using System.Collections;

public enum enemyMoveStates
{
	enemyIdle,
	enemyRun,
	enemyWalkBack,
	enemyAttack1,
	enemyAttack2,
	enemyAttack3,
	enemyAttack4,
	enemyAttack5,
	enemyDeath,
	enemyDamage
}

public class EnemyMoveFSM : MonoBehaviour 
{
	public AnimationClip enemyIdle;
	public AnimationClip enemyRun;
	public AnimationClip enemyWalkBack;
	public AnimationClip enemyAttack1;
	public AnimationClip enemyAttack2;
	public AnimationClip enemyAttack3;
	public AnimationClip enemyAttack4;
	public AnimationClip enemyAttack5;
	public AnimationClip enemyDeath;
	public AnimationClip enemyDamage;

	public enemyMoveStates CurrentState;
	
	//public enemyMoveStates PreviousState;
	
	//public float MoveSpeed;
	
	//public float TurnSpeed;
	
	string currentAnimation;
	
	Animation animation;
	
	void Awake()
	{

		animation = gameObject.animation;
		
		#region setting up animator
		animation.playAutomatically = true;
		
		animation.AddClip(enemyIdle, "idle");
		animation.AddClip(enemyRun, "run");
		animation.AddClip(enemyWalkBack, "walk_back");
		animation.AddClip(enemyAttack1, "atk01");
		animation.AddClip(enemyAttack1, "atk02");
		animation.AddClip(enemyAttack1, "atk03");
		animation.AddClip(enemyAttack1, "atk04");
		animation.AddClip(enemyAttack1, "atk05");
		animation.AddClip(enemyDeath, "die");
		animation.AddClip(enemyDamage, "hurt");
		
		animation["run"].wrapMode = WrapMode.Loop;
		animation["idle"].wrapMode = WrapMode.Loop;
		animation["walk_back"].wrapMode = WrapMode.Loop;
		animation["atk01"].wrapMode = WrapMode.Once;
		animation["atk02"].wrapMode = WrapMode.Once;
		animation["atk03"].wrapMode = WrapMode.Once;
		animation["atk04"].wrapMode = WrapMode.Once;
		animation["atk05"].wrapMode = WrapMode.Once;
		animation["hurt"].wrapMode = WrapMode.Once;
		animation["die"].wrapMode = WrapMode.Once;
		currentAnimation = "idle";
		
		#endregion
	}
	
	void Start () 
	{
		CurrentState = enemyMoveStates.enemyIdle;
		//MoveSpeed = 1.0f;
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		switch (CurrentState)
		{

		case enemyMoveStates.enemyIdle:
			animation.Play("idle", PlayMode.StopAll);

			break;
			
		case enemyMoveStates.enemyRun:
			animation.CrossFade("run", 0.1f);
			
			break; 

		case enemyMoveStates.enemyWalkBack:
			animation.CrossFade("walk_back", 0.1f);

			break;

		case enemyMoveStates.enemyAttack1:
			animation.CrossFade("atk01", 0.1f);

			break;

		case enemyMoveStates.enemyAttack2:
			animation.CrossFade("atk02", 0.1f);

			break;

		case enemyMoveStates.enemyAttack3:
			animation.CrossFade("atk03", 0.1f);

			break;

		case enemyMoveStates.enemyAttack4:
			animation.CrossFade("atk04", 0.1f);

			break;

		case enemyMoveStates.enemyAttack5:
			animation.CrossFade("atk05", 0.1f);

			break;
		
		case enemyMoveStates.enemyDamage:
			animation.CrossFade("hurt", 0.1f);

			break;

		case enemyMoveStates.enemyDeath:
			animation.CrossFade("die", 0.1f);

			break;

		default:
			
			break;
			
		}
	}
	

}