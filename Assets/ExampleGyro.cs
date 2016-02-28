using UnityEngine;
using System.Collections;

public class ExampleGyro : MonoBehaviour {

	public float shakeSpeed;
	public AudioClip[] chords;
	public GameObject[] letters;
	private AudioSource audio;

	void Start() {
		audio = GetComponent<AudioSource>();
	}

	void Update() {
		

			if (Input.deviceOrientation == DeviceOrientation.FaceDown)
			{
			
				letters[0].gameObject.SetActive(true);
				letters[1].gameObject.SetActive(false);
				letters[2].gameObject.SetActive(false);
				letters[3].gameObject.SetActive(false);
				letters[4].gameObject.SetActive(false);
				letters[5].gameObject.SetActive(false);
				letters[6].gameObject.SetActive(false);

				if (Input.GetTouch(0).phase == TouchPhase.Began && Input.touchCount > 0)
				{
					audio.PlayOneShot(chords[0]);
				}

			}

			if (Input.deviceOrientation == DeviceOrientation.FaceUp)
			{
			
				letters[1].gameObject.SetActive(true);
				letters[6].gameObject.SetActive(false);
				letters[2].gameObject.SetActive(false);
				letters[3].gameObject.SetActive(false);
				letters[4].gameObject.SetActive(false);
				letters[5].gameObject.SetActive(false);
				letters[0].gameObject.SetActive(false);

				if (Input.GetTouch(0).phase == TouchPhase.Began && Input.touchCount > 0)
				{
					audio.PlayOneShot(chords[1]);
				}

			}

			if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft)
			{
			
				letters[2].gameObject.SetActive(true);
				letters[1].gameObject.SetActive(false);
				letters[6].gameObject.SetActive(false);
				letters[3].gameObject.SetActive(false);
				letters[4].gameObject.SetActive(false);
				letters[5].gameObject.SetActive(false);
				letters[0].gameObject.SetActive(false);

				if (Input.GetTouch(0).phase == TouchPhase.Began && Input.touchCount > 0)
				{
					audio.PlayOneShot(chords[2]);
				}

			}

			if (Input.deviceOrientation == DeviceOrientation.LandscapeRight)
			{
			
				letters[3].gameObject.SetActive(true);
				letters[1].gameObject.SetActive(false);
				letters[2].gameObject.SetActive(false);
				letters[6].gameObject.SetActive(false);
				letters[4].gameObject.SetActive(false);
				letters[5].gameObject.SetActive(false);
				letters[0].gameObject.SetActive(false);

				if (Input.GetTouch(0).phase == TouchPhase.Began && Input.touchCount > 0)
				{
					audio.PlayOneShot(chords[3]);
				}

			}

			if (Input.deviceOrientation == DeviceOrientation.Portrait)
			{
			
				letters[4].gameObject.SetActive(true);
				letters[1].gameObject.SetActive(false);
				letters[2].gameObject.SetActive(false);
				letters[3].gameObject.SetActive(false);
				letters[6].gameObject.SetActive(false);
				letters[5].gameObject.SetActive(false);
				letters[0].gameObject.SetActive(false);

				if (Input.GetTouch(0).phase == TouchPhase.Began && Input.touchCount > 0)
				{
					audio.PlayOneShot(chords[4]);
				}
			}

			if (Input.deviceOrientation == DeviceOrientation.PortraitUpsideDown)
			{

				letters[5].gameObject.SetActive(true);
				letters[1].gameObject.SetActive(false);
				letters[2].gameObject.SetActive(false);
				letters[3].gameObject.SetActive(false);
				letters[4].gameObject.SetActive(false);
				letters[6].gameObject.SetActive(false);
				letters[0].gameObject.SetActive(false);

				if (Input.GetTouch(0).phase == TouchPhase.Began && Input.touchCount > 0)
				{
					audio.PlayOneShot(chords[5]);
				}

			}

			else if (Input.deviceOrientation == DeviceOrientation.Unknown)
			{

				letters[6].gameObject.SetActive(true);
				letters[1].gameObject.SetActive(false);
				letters[2].gameObject.SetActive(false);
				letters[3].gameObject.SetActive(false);
				letters[4].gameObject.SetActive(false);
				letters[5].gameObject.SetActive(false);
				letters[0].gameObject.SetActive(false);

				if (Input.GetTouch(0).phase == TouchPhase.Began && Input.touchCount > 0)
				{
					audio.PlayOneShot(chords[6]);
				}

			}


		
	}
}
