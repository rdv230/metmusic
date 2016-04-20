using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class buttonManager : MonoBehaviour {

	public Animator canvases;

	bool OnMouseOver = true;

	// Use this for initialization
	void Start () {
	
	

	}
	
	// Update is called once per frame
	void Update () {

	
		if (OnMouseOver)
		{
			if (Input.GetMouseButtonDown(0))
			{
				TriggerAnimation(gameObject.name);
			}
		}
	}

	public void TriggerAnimation(string name)
	{

		if (name == "Hit")
		{
			canvases.SetBool("Hit", false);
		}

		if (name == "Play")
		{
			canvases.SetBool("Hit", true);
		}
	}

	void OnMouseEnter()
	{
		OnMouseOver = true;
	}

	void OnMouseExit()
	{
		OnMouseOver = false;
	}
}
