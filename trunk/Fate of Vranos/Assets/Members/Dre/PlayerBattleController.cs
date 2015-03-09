using UnityEngine;
using System.Collections;

public class PlayerBattleController: MonoBehaviour {
	public GameObject camera;
    
    // This is the NGUI Camera GameObject
    public GameObject guiCamera;

	public GameObject[] battleCamPos;
	public float smoothTime;
	public bool battle = false;		
	private Vector3 velocity = Vector3.zero;
	public int currentCam = 0;
	
	public GameObject battlePos;
	public GameObject enemyBattlePos;

	private PlayerController controller;
	private Vector3 playerPosition;
	private PlayerBattleManager battleController;
	private GameObject currentEnemy;
	private AudioSource _audioSource;

	// Use this for initialization
	void Start () {
        guiCamera.active = false;
		controller = GetComponent<PlayerController> ();
		battleController = GetComponent<PlayerBattleManager>();
		_audioSource = GetComponent<AudioSource>();

		Messenger.AddListener("endBattle", EndBattle);

	}
	
	// Update is called once per frame
	void Update () {

		//distFromTrans = Camera.main.transform.position - transform.position;

		if (battle == true) {

			camera.transform.position = Vector3.SmoothDamp(camera.transform.position, battleCamPos[currentCam].transform.position, ref velocity, smoothTime);
			
			if (currentCam == 2)
				camera.transform.LookAt(currentEnemy.transform);
			else
				camera.transform.LookAt(gameObject.transform);

		} else {
			
			guiCamera.active = false;
			CameraFollow follow = camera.GetComponent<CameraFollow>();
			follow.enabled = true;

		}


		/*if (Input.GetKeyDown(KeyCode.Tab)) {
			if(currentCam == 2){
				currentCam = 1;
				//camera.transform.position = Vector3.SmoothDamp(camera.transform.position, battleCamPos[currentCam].transform.position, ref velocity, smoothTime);
				//camera.transform.LookAt(gameObject.transform);
			}
			else{
				currentCam++;
				//camera.transform.position = Vector3.SmoothDamp(camera.transform.position, battleCamPos[0].transform.position, ref velocity, smoothTime);
				//if(currentCam ==1)
				//	camera.transform.LookAt(gameObject.transform);
			}
		}*/

	}

	void OnTriggerEnter(Collider other){
		if (other.tag == "Enemy") {
			
			SphereCollider enemycol = other.GetComponent<SphereCollider>();
			enemycol.enabled = false;

			Messenger.Broadcast("playBattleMusic");
			battle = true;
			guiCamera.active = true;
			currentEnemy = other.gameObject;
			controller.StartBattle();
			controller.ResetRun();
			controller.ResetRunBack();

			// We need to get the player's old position to return to once the battle is complete
			playerPosition = transform.position;
			print ("position has been set by " + other.name);

			// End player find pre-battle position


			//GameInfo.BattleActive = true;  //Starts the battle
			//GameInfo.currentEnemy = other.gameObject; //Sets the current enemy to the collided enemy;


			//Transport to battle scene
			transform.position = battlePos.transform.position;
			other.transform.position = enemyBattlePos.transform.position;


			//Stops enemy from moving
			EnemyBattleController enemy = other.GetComponent<EnemyBattleController>();
			enemy.stopEnemy();

			transform.LookAt(other.gameObject.transform);//Makes player face enemy
			other.gameObject.transform.LookAt(gameObject.transform);//Makes Enemy face player

			CameraFollow follow = camera.GetComponent<CameraFollow>();
			follow.enabled = false;



			// Pass enemy to script
			battleController.StartBattle(other);
			print ("BattleActive has been set to True by collider");
		}

	}

	public void EndBattle() {
		battle = false;
		controller.EndBattle();
		transform.position = playerPosition;
		print ("Player has been transported");
	}


}
