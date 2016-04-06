using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SoundController : MonoBehaviour {

	public AudioClip MajorA;
	public AudioClip MajorB;
	public AudioClip MajorC;
	public AudioClip MajorD;
	public AudioClip MajorE;
	public AudioClip MajorF;
	public AudioClip MajorG;


	public AudioSource[] audioSources;
	bool isPlaying;

	public Slider sliderObj;
	public float currentSliderVal;


	// Use this for initialization
	void Start () {
		currentSliderVal = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.touchCount >= 1){
			Debug.Log("is");
		if(Input.GetTouch(0).phase == TouchPhase.Ended){
				Debug.Log("It as worked + \n currentSliderVal: "+ currentSliderVal + "       sliderObj.value: " + sliderObj.value);
				Debug.Log("Yes");

				ChangeClip(sliderObj.value);
				Debug.Log("CHANGE");
			}
		}
	}

	public void ChangeClip(float i){

		int num = Mathf.RoundToInt(i);

		audioSources[num].Play();
		Debug.Log(audioSources[num]);
	}

	IEnumerator Wait(){
		yield return new WaitForSeconds(5);
	}
}
