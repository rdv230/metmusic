using UnityEngine;
using System.Collections;

public class TutorialManager : MonoBehaviour {

	public GameObject tutorialImage;
	bool imageToggled;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ToggleImage()
	{
		tutorialImage.SetActive(true);
	}

	public void UnToggleImage()
	{
		tutorialImage.SetActive(false);
	}
}
