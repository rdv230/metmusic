using UnityEngine;
using System.Collections;

public class TutorialManager : MonoBehaviour {

	public GameObject tutorialImage;
	public GameObject startImage;
	public GameObject MechTutImage;

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

	public void UnToggleStart()
	{
		startImage.SetActive(false);
	}

	public void MechTut()
	{
		MechTutImage.SetActive(true);
	}

	public void UnMechTut()
	{
		MechTutImage.SetActive(false);
	}
}
