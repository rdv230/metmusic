using UnityEngine;
using System.Collections;

public class ArcExample : MonoBehaviour {

	Gyroscope gyro;
	private AudioSource audio;
	public AudioClip[] chords;

	public bool hasTouched;
	public bool swipeToGo;
	public bool playSwipe;
	void Start () {


		hasTouched = false;
		swipeToGo = false;
		playSwipe = false;
		audio = GetComponent<AudioSource>();


		gyro = Input.gyro;

		if(!gyro.enabled)
		{
			gyro.enabled = true;
		}
	}

	void Update () 
	{
		gameObject.transform.rotation  = gyro.attitude;

		Debug.Log (transform.rotation);

		//Detects Touch and changes a bool to activate notes depending on the rotation of that cube we have.

		if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began){
			hasTouched = true;
		} else{
			hasTouched = false;
		}

		if(swipeToGo){
			if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved){
				swipeToGo = false;
			}
		}

		if(Input.touchCount > 0 && !swipeToGo && Input.GetTouch(0).phase == TouchPhase.Stationary){
			swipeToGo = true;
			playSwipe = true;
		}
			


		if (transform.rotation.z <= 1 && transform.rotation.z > 0.7)
		{
			if (hasTouched||playSwipe)
			{
				audio.PlayOneShot(chords[0]);
			}
		}

		if (transform.rotation.z <= 0.7 && transform.rotation.z > 0.4)
		{
			if (hasTouched|| playSwipe)
			{
				audio.PlayOneShot(chords[1]);
				playSwipe = false;
			}
		}

		if (transform.rotation.z <= 0.4 && transform.rotation.z > 0.1)
		{
			if (hasTouched|| playSwipe)
			{
				audio.PlayOneShot(chords[2]);
				playSwipe = false;
			}
		}

		if (transform.rotation.z <= 0.1 && transform.rotation.z > -0.2)
		{
			if (hasTouched|| playSwipe)
			{
				audio.PlayOneShot(chords[3]);
				playSwipe = false;
			}
		}

		if (transform.rotation.z <= -0.2 && transform.rotation.z > -0.5)
		{
			if (hasTouched|| playSwipe)
			{
				audio.PlayOneShot(chords[4]);
				playSwipe = false;
			}
		}

		if (transform.rotation.z <= -0.5 && transform.rotation.z > -0.8)
		{
			if (hasTouched|| playSwipe)
			{
				audio.PlayOneShot(chords[5]);
				playSwipe = false;
			}
		}

		if (transform.rotation.z <= -0.8 && transform.rotation.z > -1)
		{
			if (hasTouched)
			{
				audio.PlayOneShot(chords[6]);
				playSwipe = false;
			
			}
		}
	}


}
