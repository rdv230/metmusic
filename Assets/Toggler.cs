using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Toggler : MonoBehaviour {

	public GameObject[] textsToHide;
	public GameObject[] imagesToHide;
	public GameObject mechanism;

	public bool toggled;

	public GameObject ChordButton;
	public GameObject MechButton;
	public GameObject toggleButton;
	public Sprite toggledSprite;
	public Sprite notToggledSprite;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (toggled)
		{
			foreach (GameObject text in textsToHide)
			{
				text.GetComponent<Text>().enabled = false;
			}
			foreach (GameObject image in imagesToHide)
			{
				image.GetComponent<Image>().enabled = false;
			}
			mechanism.SetActive(true);
			toggleButton.GetComponent<Image>().sprite = toggledSprite;
			ChordButton.SetActive(false);
			MechButton.SetActive(true);
		}

		else if (!toggled)
		{
			foreach (GameObject text in textsToHide)
			{
				text.GetComponent<Text>().enabled = true;
			}
			foreach (GameObject image in imagesToHide)
			{
				image.GetComponent<Image>().enabled = true;
			}
			mechanism.SetActive(false);
			toggleButton.GetComponent<Image>().sprite = notToggledSprite;
			ChordButton.SetActive(true);
			MechButton.SetActive(false);
		}

	}

	public void Toggle()
	{
		if (toggled)
		{
			toggled = false;
		}
		else if (!toggled)
		{
			toggled = true;
		}
	}

	public void PlayAnim()
	{
		if (toggled)
		{
			Debug.Log ("playing");
			mechanism.SetActive(false);
		}
			
	}
}
