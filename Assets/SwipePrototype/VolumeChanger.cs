using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class VolumeChanger : MonoBehaviour {

	float factor = 100.0f;

	private float startTime;
	private Vector3 startPos;

	public Sprite KeySprite;
	public GameObject volumeSlider;

	bool keyPressed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	



		volumeSlider.GetComponent<Image>().fillAmount = Mathf.Lerp(volumeSlider.GetComponent<Image>().fillAmount, 0, Time.deltaTime * 0.3f);


	}

	void OnMouseDown() {
		startTime = Time.time;
		startPos = Input.mousePosition;
		startPos.z = transform.position.z - Camera.main.transform.position.z;
		startPos = Camera.main.ScreenToWorldPoint(startPos);
	}

	void OnMouseUp() {
		Vector3 endPos = Input.mousePosition;
		endPos.z = transform.position.z - Camera.main.transform.position.z;
		endPos = Camera.main.ScreenToWorldPoint(endPos);

		Vector3 force = endPos - startPos;
		force.z = force.magnitude;
		force /= (Time.time - startTime);

		GetComponent<AudioSource>().volume = Mathf.Abs(force.y)/15;
		GetComponent<AudioSource>().Play();

		keyPressed = true;

		volumeSlider.GetComponent<Image>().fillAmount = Mathf.Lerp(volumeSlider.GetComponent<Image>().fillAmount, GetComponent<AudioSource>().volume, Time.deltaTime * 50);

		transform.parent.GetComponent<SpriteRenderer>().sprite = KeySprite;
	}
}
