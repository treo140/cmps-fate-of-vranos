using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

	public EnemyMoveFSM moveFSM;
	public float moveSpeed;
	private float origMoveSpeed;
	public float turnSpeed;
	public float gravity;
	public float yOffSet;

	//private PlayerController controller;
	private Rigidbody rBody;
	private float distToGround;
	public float distOffset; // the added distance for calculating if play is on the ground

	private float distFromBody; // used to determine if the slope of the object in front of the player is a steep slope

	// Use this for initialization
	void Start () 
	{
		yOffSet = 0.5f;
		gravity = -9.81f;
		//controller = GetComponent<PlayerController> ();	// reference to the PlayerController on the player
		origMoveSpeed = moveSpeed;		// reference to the original movement speed of the player
		rBody = GetComponent<Rigidbody> (); 	// reference to the rigidbody on the player
		distToGround = collider.bounds.extents.y; // reference to the distance to the ground
		distFromBody = collider.bounds.extents.z; // reference to the distance to the terrain in front of the player
		distOffset = 1;
	}
	
	// Update is called once per frame
	void Update () {

		moveSpeed = origMoveSpeed;		// this handles the speed of the player when running or running back

		/*if (!isGrounded () || checkSlope(1) || checkSlope(-1)) 
		{
			controller.rigidbody.velocity = new Vector3(0,-9.81f,0);	
			moveSpeed = 0;
		}*/

		//if (controller.inBattle () == false) {	// check to see if the player is in a battle, if so it shouldn't be able to move around

			if (Input.GetKeyDown (KeyCode.Tab)) {
				if (moveSpeed < 30 ) {
					origMoveSpeed = 30f;
				} else {
					origMoveSpeed = 10f;
				}
			}
			
			if (Input.GetKeyUp (KeyCode.W)) {
			//	controller.ResetRun ();	// stop the running animation
			}

			if (Input.GetKey (KeyCode.W)){// && isGrounded()) {

				//if (!isGrounded () || checkSlope(1)) // check if player is not on ground or if there is a slope in front of the player
					//moveSpeed = 0;

				//if(!checkSlope(1)){
					//moveSpeed = origMoveSpeed;
					transform.position += moveSpeed * Time.deltaTime * transform.forward;
					//controller.Run ();	// start the running animation
				//}
			}

			if (Input.GetKeyUp (KeyCode.S)) {
				//controller.ResetRunBack (); // stop the run back animation
			}

			if (Input.GetKey (KeyCode.S) && isGrounded()) 
			{
				moveSpeed = -5.0f;		// decrease move speed since the player will be moving backward
				transform.position += moveSpeed * Time.deltaTime * transform.forward;
				//if(!isGrounded())
				//{
				//	transform.position += transform.up * Time.deltaTime * gravity * moveSpeed;
				//}
				//controller.RunBack ();	// start the run back animation
			}
		
			if (Input.GetKey (KeyCode.A)) {
				Turn (-1);
				//transform.position += moveSpeed * Time.deltaTime * transform.right;
				//controller.Strafe ();
			}

			if (Input.GetKey (KeyCode.D)) {
				Turn (1);
				//transform.position += moveSpeed * Time.deltaTime * transform.right;
				//controller.Strafe ();
			}
			
			//transform.position +=  Time.deltaTime * transform.up * gravity;
			/*if (Input.GetKey (KeyCode.S)) && !isGrounded()) 
			{
				//moveSpeed = 2.0f;
				//transform.position += moveSpeed * Time.deltaTime * transform.up * gravity;

				//transform.position += moveSpeed * Time.deltaTime * transform.forward * gravity;
				controller.ResetRunBack(); // stop the run back animation

			}*/

				
		}
		
	//}


	public void Turn(int direction)
	{
		transform.Rotate(Vector3.up, direction * turnSpeed * Time.deltaTime);
	}

	public bool isGrounded()
	{
		return Physics.Raycast(new Vector3(transform.position.x,transform.position.y + distToGround,transform.position.z), Vector3.down, distToGround + yOffSet);
		// checks if the player is grounded or not and returns the result
	}

	public bool checkSlope(int direction)
	{
		//Debug.DrawLine(new Vector3(transform.position.x,transform.position.y + distToGround,transform.position.z), new Vector3(transform.position.x, transform.position.y + distToGround, transform.position.z + direction * distFromBody + distOffset));
		return Physics.Raycast(new Vector3(transform.position.x,transform.position.y + distToGround,transform.position.z), Vector3.forward, distFromBody + distOffset);
	}


}
