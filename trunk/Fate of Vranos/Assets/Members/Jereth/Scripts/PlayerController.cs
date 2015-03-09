using UnityEngine;
using System.Collections;

// Require these components when using this script
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(CapsuleCollider))]
//[RequireComponent(typeof(Rigidbody))]

public class PlayerController : MonoBehaviour {


	public float animSpeed = 1.0f;
	private Animator anim;  // referance to the animator on the player
	private AnimatorStateInfo currentBaseState;  // a reference to the current state for the base layer
	private AnimatorStateInfo layer2CurrentState; // a reference to the current state of the 2nd layer
	// This is used if jumping is implemented
	private CapsuleCollider col;	// a reference to the capsule collider on the player




	// Use this for initialization
	void Start () {

		// initialize reference variables
		anim = GetComponent<Animator> ();
		col = GetComponent<CapsuleCollider> ();


		if (anim.layerCount == 2)
						anim.SetLayerWeight (1, 1);

	
	}

	void FixedUpdate()
	{

		float h = Input.GetAxis ("Horizontal");						// setup h variable as our horizontal input axis
		float v = Input.GetAxis ("Vertical");						// setup v variable as our vertical input axis
		//anim.SetFloat ("Speed", v);									// set our animator's Speed parameter equal to the vertical input axis
		//anim.SetFloat ("Direction", h);								// set our animator's Direction parameter equal to the horizontal axis
		anim.speed = animSpeed;										// set the speed of our animator to the public variable animSpeed
		currentBaseState = anim.GetCurrentAnimatorStateInfo (0);	// set our currentState variable to the current state of the Base Layer (0) of the animator

		if (anim.layerCount == 2)
						layer2CurrentState = anim.GetCurrentAnimatorStateInfo (1);

	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void LateUpdate()
	{
		ResetStab ();
		ResetUppercut ();
		ResetOverHead ();

	}

	public void StartBattle()
	{
		anim.SetBool ("InBattle", true);
	}

	public void EndBattle()
	{
		anim.SetBool ("InBattle", false);
	}

	public bool inBattle()
	{
		return anim.GetBool ("InBattle");
	}

	public void Run()
	{
		anim.SetBool ("Run", true);
	}

	public void RunBack()
	{
		anim.SetBool ("RunBack", true);
	}

	public void ResetRun()
	{
		anim.SetBool ("Run", false);
	}

	public void ResetRunBack()
	{
		anim.SetBool ("RunBack", false);
	}

	public void TakeDamage()
	{
		anim.SetBool ("Damage", true);
	}

	public void StopDamage()
	{
		anim.SetBool ("Damage", false);
	}

	public void Stab()
	{
		anim.SetBool ("Stab", true);
	}

	public void ResetStab()
	{
		anim.SetBool ("Stab", false);
	}

	public void Uppercut()
	{
		anim.SetBool ("Uppercut", true);
	}

	public void OverHead()
	{
		anim.SetBool ("OverHead", true);
	}

	public void ResetUppercut()
	{
		anim.SetBool ("Uppercut", false);
	}
	
	public void ResetOverHead()
	{
		anim.SetBool ("OverHead", false);
	}


}
