using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TestingArc : MonoBehaviour {


	Gyroscope gyro;
	AudioSource myAudio;
	public AudioClip[] MajorChords;
	public AudioClip[] MinorChords;
	public bool hasTouched;
	public bool hasSwiped;
	public bool playSwipe;

	public GameObject TextObject;
	public string chordText;
	public string cText;
	public GameObject minorTextObj;

	bool justPlayed;
	float time2PlayAgain;

	// Use this for initialization
	void Start () {
		hasTouched = false;
		hasSwiped = false;
		playSwipe = false;
		myAudio = GetComponent<AudioSource>();

		gyro = Input.gyro;
		if(!gyro.enabled){
			gyro.enabled = true;
		}

	}
	
	// Update is called once per frame
	void Update () {

		//chordText is the text on the Screen ,NOT including the minor "m" symbol
		chordText = ChangeChordText();
		TextObject.GetComponent<Text>().text = chordText;
		minorTextObj.GetComponent<Text>().text = chordText+"m";


		//Debug Purposes if we activate the pointer and the old canvas
		gameObject.transform.rotation = gyro.attitude;

		if(Input.touchCount > 0){
			Debug.Log(Input.GetTouch(0).position);
		}
//		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
//			hasTouched = true;
//		} else{
//			hasTouched = false;
//		}

		if(!playSwipe && !hasSwiped && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
				hasSwiped = true;
			}

		if(Input.touchCount > 0 && hasSwiped && Input.GetTouch(0).phase == TouchPhase.Stationary){
			hasSwiped = false;
			playSwipe = true;
		}
			

		Vector3 dir = Vector3.zero;
		dir.x = Input.acceleration.x;
		dir.z = Input.acceleration.z;

		if(!justPlayed){

		if(dir.x < 0 &&dir.sqrMagnitude> 0.4f){
			Debug.Log("dir.x: "+ dir.x);


			float soundLevel = Mathf.Clamp01(Mathf.Abs(dir.x));
			Debug.Log("SoundLevel: "+soundLevel);
//		if(hasTouched||playSwipe){
//			if(Input.GetTouch(0).position.x <= 89){
			PlaySound(MajorChords, soundLevel);
				}
		}

		if(justPlayed){
			time2PlayAgain+= Time.deltaTime;

			if(time2PlayAgain >= 0.1f){
				justPlayed = true;
				time2PlayAgain = 0;
			}
		}
			
//			if(Input.GetTouch(0).position.x > 89){
//				
//					PlaySound(MinorChords);
//				}
	}
		

	void PlaySound(AudioClip[] currentChords,float volumeScale){

		if(transform.rotation.z <= 1 && transform.rotation.z > 0.715){
			myAudio.PlayOneShot(currentChords[0],volumeScale);

		}else if(transform.rotation.z <= 0.715 && transform.rotation.z > 0.43){
			myAudio.PlayOneShot(currentChords[1],volumeScale);

		}else if(transform.rotation.z <= 0.43 && transform.rotation.z > 0.145){ 
			myAudio.PlayOneShot(currentChords[2],volumeScale);

		}else if(transform.rotation.z <= 0.145 && transform.rotation.z > -0.14){
			myAudio.PlayOneShot(currentChords[3],volumeScale);

		}else if(transform.rotation.z <= -0.14 && transform.rotation.z > -0.425){
			myAudio.PlayOneShot(currentChords[4],volumeScale);

		}else if(transform.rotation.z <= -0.425 && transform.rotation.z > -0.71){
			myAudio.PlayOneShot(currentChords[5],volumeScale);

		}else if(transform.rotation.z <= -0.71 && transform.rotation.z > -1){
			myAudio.PlayOneShot(currentChords[6],volumeScale);
		}
		playSwipe = false;
	}

	string ChangeChordText(){

			if(transform.rotation.z <= 1 && transform.rotation.z > 0.715){
				cText = "A";

			}else if(transform.rotation.z <= 0.715 && transform.rotation.z > 0.43){
				cText = "B";

			}else if(transform.rotation.z <= 0.43 && transform.rotation.z > 0.145){ 
				cText = "C";

			}else if(transform.rotation.z <= 0.145 && transform.rotation.z > -0.14){
				cText = "D";

			}else if(transform.rotation.z <= -0.14 && transform.rotation.z > -0.425){
				cText = "E";

			}else if(transform.rotation.z <= -0.425 && transform.rotation.z > -0.71){
				cText = "F";

			}else if(transform.rotation.z <= -0.71 && transform.rotation.z >= -1){
				cText = "G";
			}
		return cText;
	}


	void Sound(){
		
	}
}
