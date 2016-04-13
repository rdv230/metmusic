using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ChordChanger : MonoBehaviour {


	//Gyroscopic Variables
	Gyroscope gyro;
	Vector3 dir;
	float zRotation = 0;


	//Piano Keys, Sounds & Text
	public Sprite[] pianoKeys;
	AudioSource myAudio;
	public AudioClip[] Chords;
	public AudioClip currentChord;
	public string chordText;


	//Playable Variables
	bool justPlayed;
	float time2PLayAgain;



	// Use this for initialization
	void Start () {


		//Initiate Gyro
		gyro = Input.gyro;
		if(!gyro.enabled){
			gyro.enabled = true;
		}
		Input.gyro.updateInterval = 0.1F;

		//Initiate Other Variables
		dir = Vector3.zero;
		myAudio = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {

		ChordToPlay(zRotation);
		if(Input.deviceOrientation == DeviceOrientation.FaceUp){
			zRotation =  transform.rotation.z;
			dir = Vector3.zero;
			dir.x = Input.acceleration.x;
			dir.z = Input.acceleration.z;
			if(dir.z < -0.5f && dir.sqrMagnitude > 0.8f){
				float soundLevel = Mathf.Clamp01(Mathf.Abs(dir.z * 0.2f));
				PlayChord(currentChord,soundLevel);
			}


		}
			

	
	}


	void ChordToPlay(float z){
		int switchCaseInt = new int(); 
		if(z <= 1f && z > 7/8f){
			switchCaseInt = 0;
			Debug.Log("THIS");
		}else if(z <= 7/8f && z > 6/8f){
			Debug.Log("THISTHAT");
			switchCaseInt = 1;
		}else if(z <= 6/8f && z > 5/8f){
			switchCaseInt = 2;
		}else if(z <= 5/8f && z > 4/8f){
			switchCaseInt = 3;
		}else if(z <= 4/8f && z > 3/8f){
			switchCaseInt = 4;
		}else if(z <= 3/8f && z > 2/8f){
			switchCaseInt = 5;
		}else if(z <= 2/8f && z > 1/8f){
			switchCaseInt = 6;
		}else if(z <= 1/8f && z > 0f){
			switchCaseInt = 7;
		}

		chordText = SwitchText(switchCaseInt);
	}

	string SwitchText(int switchCaseInt){
		string text = " ";
		switch(switchCaseInt){
		case 0:
			currentChord = Chords[switchCaseInt];
			text = "C";
			break;
		case 1:
			currentChord = Chords[switchCaseInt];
			text = "D";
			break;
		case 2:
			currentChord = Chords[switchCaseInt];
			text = "E";
			break;
		case 3:
			currentChord = Chords[switchCaseInt];
			text = "F";
			break;
		case 4:
			currentChord = Chords[switchCaseInt];
			text = "G";
			break;
		case 5:
			currentChord = Chords[switchCaseInt];
			text = "A";
			break;
		case 6:
			currentChord = Chords[switchCaseInt];
			text = "B";
			break;
		case 7:
			currentChord = Chords[switchCaseInt];
			text = "C";
			break;
		}

		return text;
	}

	void PlayChord(AudioClip chord, float volumeScale){
		myAudio.PlayOneShot(chord, volumeScale);
	}
}
