using UnityEngine;
using System.Collections;

public class ScreenManager : MonoBehaviour {

	public GameObject GameCanvas;
	public GameObject constantCanvas;
	public GameObject playCanvas;

	public Transform comeInPlay;
	public Transform comeOutPlay;

	public Transform comeInGame;
	public Transform comeOutGame;
	public Transform playGame;
	public Transform hitGame;

	public Transform comeInConstant;
	public Transform comeOutConstant;

	bool movingGameCanvasIn;
	bool movingPlayCanvasIn;

	bool hitting;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (movingGameCanvasIn)
		{
			GameCanvas.transform.position = Vector2.MoveTowards(GameCanvas.transform.position, comeInGame.position, 10*Time.deltaTime);
			constantCanvas.transform.position = Vector2.MoveTowards(constantCanvas.transform.position, comeInConstant.position, 50*Time.deltaTime);

			if (hitting)
			{
				GameCanvas.transform.position = Vector2.MoveTowards(GameCanvas.transform.position, hitGame.position, 20*Time.deltaTime);
			}

			else
			{
				GameCanvas.transform.position = Vector2.MoveTowards(GameCanvas.transform.position, comeInGame.position, 10*Time.deltaTime);
			}
		}
		else
		{
			GameCanvas.transform.position = Vector2.MoveTowards(GameCanvas.transform.position, comeOutGame.position, 20*Time.deltaTime);
			constantCanvas.transform.position = Vector2.MoveTowards(constantCanvas.transform.position, comeOutConstant.position, 20*Time.deltaTime);

		}

		if (movingPlayCanvasIn)
		{
			playCanvas.transform.position = Vector2.MoveTowards(playCanvas.transform.position, comeInPlay.position, 20*Time.deltaTime);
		}
		else 
		{
			playCanvas.transform.position = Vector2.MoveTowards(playCanvas.transform.position, comeOutPlay.position, 20*Time.deltaTime);
		}

	}

	public void MoveGameCanvas(string dir)
	{
		if (dir == "Out")
		{
			//GameCanvas.GetComponent<Animator>().enabled = false;
			movingGameCanvasIn = false;
		}

		if (dir == "In")
		{
			//GameCanvas.GetComponent<Animator>().enabled = true;
			movingGameCanvasIn = true;
		}
	}

	public void MovePlayCanvas(string dir)
	{
		if (dir == "Out")
		{
			movingPlayCanvasIn = false;

		}

		if (dir == "In")
		{
			movingPlayCanvasIn = true;
		}
	}

	public void HammerPianoToggle(string dir)
	{
		if (dir == "Hit")
		{
			hitting = false;
		}

		if (dir == "Play")
		{
			hitting = true;
		}
	}
		
}
