using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttonManager : MonoBehaviour {

	public Animator AppCanvases;

	public ScreenManager screens;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}


	void OnMouseDown()
	{
		TriggerAnimation(gameObject.name);
	}

	public void TriggerAnimation(string name)
	{
		if (name == "Hit")
		{
			AppCanvases.SetBool("Hit", true);
		}

		if (name == "Play")
		{
			AppCanvases.SetBool("Hit", false);
		}

		if (name == "Piano")
		{
			screens.MovePlayCanvas("In");
		}

		if (name == "PlayInstrument")
		{
			screens.MoveGameCanvas("In");
		}
	}

}
