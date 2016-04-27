using UnityEngine;
using System.Collections;

public class touchSprite : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetMouseButton(0))
		{
			Debug.Log ("mouse!");
			GetComponent<SpriteRenderer>().enabled = true;
			transform.position = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
		}
		else
		{
			GetComponent<SpriteRenderer>().enabled = false;
		}
	}
}
