using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChordController : MonoBehaviour {

	public GameObject Toggler;
	Gyroscope gyro;
	Vector3 dir;


	AudioSource myAudio;
	public AudioClip[] MajorChords;
	public Sprite[] pianoKeys;
	public Image piano;

	public GameObject TextObject;
	public string cText;


	bool justPlayed;
	float time2PlayAgain;

	// Use this for initialization
	void Start () {
		dir = Vector3.zero;
		myAudio = GetComponent<AudioSource>();

		gyro = Input.gyro;
		if(!gyro.enabled){
			gyro.enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		TextObject.GetComponent<Text>().text = ChangeChordText();
		gameObject.transform.rotation = gyro.attitude;

		if(!justPlayed){
			dir = Vector3.zero;
			dir.x = Input.acceleration.x;
			dir.z = Input.acceleration.z;

			if(dir.x < 0f && dir.z < -1.3f && dir.sqrMagnitude> 0.8f){
				Debug.Log("dir: "+ dir);
				float soundLevel = Mathf.Clamp01(Mathf.Abs(dir.z * 0.2f));
				Debug.Log("SoundLevel: "+soundLevel);
				Toggler.GetComponent<Toggler>().PlayAnim();

				PlaySound(MajorChords, soundLevel);

				dir = Vector3.zero;
				justPlayed = true;
			}
		}

		if(justPlayed){
			dir = Vector3.zero;
			time2PlayAgain+= Time.deltaTime;

			if(time2PlayAgain >= 0.1f){
				dir = Vector3.zero;
				justPlayed = false;
				time2PlayAgain = 0;
			}
		}

	}
		

	void PlaySound(AudioClip[] currentChords,float volumeScale){

		if(transform.rotation.z <= 1 && transform.rotation.z > 0.75){
			myAudio.PlayOneShot(currentChords[0],volumeScale);

		}else if(transform.rotation.z <= 0.75 && transform.rotation.z > 0.5){
			myAudio.PlayOneShot(currentChords[1],volumeScale);

		}else if(transform.rotation.z <= 0.5 && transform.rotation.z > 0.25){ 
			myAudio.PlayOneShot(currentChords[2],volumeScale);

		}else if(transform.rotation.z <= 00.25 && transform.rotation.z > 0){
			myAudio.PlayOneShot(currentChords[3],volumeScale);

		}else if(transform.rotation.z <= 0 && transform.rotation.z > -0.25){
			myAudio.PlayOneShot(currentChords[4],volumeScale);

		}else if(transform.rotation.z <= -0.25 && transform.rotation.z > -0.5){
			myAudio.PlayOneShot(currentChords[5],volumeScale);

		}else if(transform.rotation.z <= -0.5 && transform.rotation.z > -0.75){
			myAudio.PlayOneShot(currentChords[6],volumeScale);
		}else if(transform.rotation.z <= -0.75 && transform.rotation.z > -1){
			myAudio.PlayOneShot(currentChords[7],volumeScale);
		}
	}

	string ChangeChordText(){

		if(transform.rotation.z <= 1 && transform.rotation.z > 0.75){
			cText = "Chord: A";
			piano.sprite = pianoKeys[0];
		}else if(transform.rotation.z <= 0.75 && transform.rotation.z > 0.5){
			cText = "Chord: B";
			piano.sprite = pianoKeys[1];

		}else if(transform.rotation.z <= 0.5 && transform.rotation.z > 0.25){ 
			cText = "Chord: C";
			piano.sprite = pianoKeys[2];

		}else if(transform.rotation.z <= 0.25 && transform.rotation.z > 0){
			cText = "Chord: D";
			piano.sprite = pianoKeys[3];

		}else if(transform.rotation.z <= 0 && transform.rotation.z > -0.25){
			cText = "Chord: E";
			piano.sprite = pianoKeys[4];

		}else if(transform.rotation.z <= -0.25 && transform.rotation.z > -0.5){
			cText = "Chord: F";
			piano.sprite = pianoKeys[5];

		}else if(transform.rotation.z <= -0.5 && transform.rotation.z >= -0.75){
			cText = "Chord: G";
			piano.sprite = pianoKeys[6];

		}else if(transform.rotation.z <= -0.75 && transform.rotation.z >= -1){
			cText = "Chord: C";
			piano.sprite = pianoKeys[7];

		}
		return cText;
	}
}
