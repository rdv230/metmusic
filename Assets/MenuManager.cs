using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SwitchScene(int sceneNum)
	{
		if (sceneNum == 2)
		{
			SceneManager.LoadScene("Prototype3-S2");
		}
		else if (sceneNum == 3)
		{
			SceneManager.LoadScene("Prototype3-S3");
		}
		else if (sceneNum == 1)
		{
			SceneManager.LoadScene("Prototype3-S1");
		}
	}
}
