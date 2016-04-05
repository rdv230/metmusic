using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TutorialChange : MonoBehaviour {

	int tutorialText = 0;
	public string[] tutorialTexts;

	public Button chev1;
	public Button chev2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		GetComponent<Text>().text = tutorialTexts[tutorialText];

	}

	public void IntUp()
	{
		tutorialText++;
		if (tutorialText >  6)
		{
			tutorialText = 7;
			HideButtons();
		}
	}

	public void IntDown()
	{
		tutorialText--;
		if (tutorialText < 0)
		{
			tutorialText = 0;
		}
	}

	void HideButtons()
	{
		chev1.gameObject.SetActive(false);
		chev2.gameObject.SetActive(false);
	}

}
