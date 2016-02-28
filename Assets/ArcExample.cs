using UnityEngine;
using System.Collections;

public class ArcExample : MonoBehaviour {

	Gyroscope gyro;
	private AudioSource audio;
	public AudioClip[] chords;

	void Start () {

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

		if (transform.rotation.z <= 1 && transform.rotation.z > 0.7)
		{
			if (Input.GetTouch(0).phase == TouchPhase.Began && Input.touchCount > 0)
			{
				audio.PlayOneShot(chords[0]);
			}
		}

		if (transform.rotation.z <= 0.7 && transform.rotation.z > 0.4)
		{
			if (Input.GetTouch(0).phase == TouchPhase.Began && Input.touchCount > 0)
			{
				audio.PlayOneShot(chords[1]);
			}
		}

		if (transform.rotation.z <= 0.4 && transform.rotation.z > 0.1)
		{
			if (Input.GetTouch(0).phase == TouchPhase.Began && Input.touchCount > 0)
			{
				audio.PlayOneShot(chords[2]);
			}
		}

		if (transform.rotation.z <= 0.1 && transform.rotation.z > -0.2)
		{
			if (Input.GetTouch(0).phase == TouchPhase.Began && Input.touchCount > 0)
			{
				audio.PlayOneShot(chords[3]);
			}
		}

		if (transform.rotation.z <= -0.2 && transform.rotation.z > -0.5)
		{
			if (Input.GetTouch(0).phase == TouchPhase.Began && Input.touchCount > 0)
			{
				audio.PlayOneShot(chords[4]);
			}
		}

		if (transform.rotation.z <= -0.5 && transform.rotation.z > -0.8)
		{
			if (Input.GetTouch(0).phase == TouchPhase.Began && Input.touchCount > 0)
			{
				audio.PlayOneShot(chords[5]);
			}
		}

		if (transform.rotation.z <= -0.8 && transform.rotation.z > -1)
		{
			if (Input.GetTouch(0).phase == TouchPhase.Began && Input.touchCount > 0)
			{
				audio.PlayOneShot(chords[6]);
			}
		}
	}
}
