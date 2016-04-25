using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttonManager : MonoBehaviour {

	public ScreenManager screens;

	public GameObject playInstrument;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}


	void OnMouseDown()
	{
		TriggerAnimation(gameObject.name);
		Debug.Log (gameObject.name);
	}

	public void TriggerAnimation(string name)
	{
		if (name == "Hit")
		{
//			AppCanvases.SetBool("Hit", true);
			screens.HammerPianoToggle("Hit");
		}

		if (name == "Play")
		{
//			AppCanvases.SetBool("Hit", false);
			screens.HammerPianoToggle("Play");

		}

		if (name == "Piano")
		{
			screens.MovePlayCanvas("In");
		}

		if (name == "PlayInstrument")
		{
			playInstrument.GetComponent<BoxCollider2D>().enabled = false;
			screens.MoveGameCanvas("In");
		}

		if (name == "Play-X")
		{
			screens.MovePlayCanvas("Out");
		}

		if (name == "Game-X")
		{
			screens.MoveGameCanvas("Out");
			playInstrument.GetComponent<BoxCollider2D>().enabled = true;
		}
	}

}
