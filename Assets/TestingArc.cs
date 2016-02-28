using UnityEngine;
using System.Collections;

public class TestingArc : MonoBehaviour {


	Gyroscope gyro;
	AudioSource myAudio;
	public AudioClip[] MajorChords;
	public AudioClip[] MinorChords;
	public bool hasTouched;
	public bool hasSwiped;
	public bool playSwipe;





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
		gameObject.transform.rotation = gyro.attitude;

		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
			hasTouched = true;
		} else{
			hasTouched = false;
		}

		if(!playSwipe && !hasSwiped && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
				hasSwiped = true;
			}

		if(Input.touchCount > 0 && hasSwiped && Input.GetTouch(0).phase == TouchPhase.Stationary){
			hasSwiped = false;
			playSwipe = true;
		}




		if(hasTouched||playSwipe){
			if(transform.rotation.x > 0 && transform.rotation.x <= 1){
				PlaySound(MajorChords);
			}else{
				PlaySound(MinorChords);
			}

		}
		Debug.Log(transform.rotation);

	}

	void PlaySound(AudioClip[] currentChords){

		if(transform.rotation.z <= 1 && transform.rotation.z > 0.715){
			myAudio.PlayOneShot(currentChords[0]);
		}else if(transform.rotation.z <= 0.715 && transform.rotation.z > 0.43){
			myAudio.PlayOneShot(currentChords[1]);
		}else if(transform.rotation.z <= 0.43 && transform.rotation.z > 0.145){ 
			myAudio.PlayOneShot(currentChords[2]);
		}else if(transform.rotation.z <= 0.145 && transform.rotation.z > -0.14){
			myAudio.PlayOneShot(currentChords[3]);
		}else if(transform.rotation.z <= -0.14 && transform.rotation.z > -0.425){
			myAudio.PlayOneShot(currentChords[4]);
		}else if(transform.rotation.z <= -0.425 && transform.rotation.z > -0.71){
			myAudio.PlayOneShot(currentChords[5]);
		}else if(transform.rotation.z <= -0.71 && transform.rotation.z > -1){
			myAudio.PlayOneShot(currentChords[6]);
		}
		playSwipe = false;
	}
}
