using UnityEngine;
using System.Collections;

public class CameraSound : MonoBehaviour {

	private AudioSource _audioSource;

	// Use this for initialization
	void Start () {
		Messenger.AddListener("playBattleMusic",PlayBattleMusic);
		Messenger.AddListener ("stopBattleMusic",StopBattleMusic);
		
		_audioSource = GetComponent<AudioSource>();
		_audioSource.clip = (AudioClip)Resources.Load ("videogame_roam", typeof(AudioClip));
		_audioSource.Play ();
	}
	
	void PlayBattleMusic() {
		_audioSource.clip = (AudioClip)Resources.Load ("new_hah", typeof(AudioClip));
		_audioSource.Play ();
	}
	
	void StopBattleMusic() {
		_audioSource.clip = (AudioClip)Resources.Load ("videogame_roam", typeof(AudioClip));
		_audioSource.Play ();
	}

}
