using UnityEngine;
using System.Collections;

public class NewInputManager : MonoBehaviour {

	public EnemyMoveFSM moveFSM;
	public float moveSpeed;
	private float walkSpeed;
	private float origMoveSpeed;
	public float turnSpeed;

	// Use this for initialization
	void Start () {

		moveFSM = GetComponent<EnemyMoveFSM> ();
		walkSpeed = moveSpeed / 2;
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.A)) {
	
						if (Input.GetKey (KeyCode.W)) {
								transform.position -= moveSpeed * Time.deltaTime * transform.forward;
								moveFSM.CurrentState = enemyMoveStates.enemyRun;

								if (Input.GetKey (KeyCode.A)) {
									Turn (-1);
								}
								if (Input.GetKey (KeyCode.D)) {
									Turn (1);
								}
								if (Input.GetKey (KeyCode.S)) {
									transform.position += moveSpeed * Time.deltaTime * transform.forward;
									moveFSM.CurrentState = enemyMoveStates.enemyIdle;
								}


						}

						if (Input.GetKey (KeyCode.S)) {
								transform.position += walkSpeed * Time.deltaTime * transform.forward;
								moveFSM.CurrentState = enemyMoveStates.enemyWalkBack;

								if (Input.GetKey (KeyCode.A)) {
									Turn (-1);
								}
								if (Input.GetKey (KeyCode.D)) {
									Turn (1);
								}
								if (Input.GetKey (KeyCode.W)) {
									transform.position -= walkSpeed * Time.deltaTime * transform.forward;
									moveFSM.CurrentState = enemyMoveStates.enemyIdle;
								}

						}

						if (Input.GetKey (KeyCode.A) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S)) {
								Turn (-1);
								moveFSM.CurrentState = enemyMoveStates.enemyIdle;
						}

						if (Input.GetKey (KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S)) {
								Turn (1);
								moveFSM.CurrentState = enemyMoveStates.enemyIdle;
						}

		}


		else {
			moveFSM.CurrentState = enemyMoveStates.enemyIdle;
		}

	}

	public void Turn(int direction)
	{
		transform.Rotate(Vector3.up, direction * turnSpeed * Time.deltaTime);
	}

}
