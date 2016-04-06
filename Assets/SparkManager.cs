using UnityEngine;
using System.Collections;

public class SparkManager : MonoBehaviour {

	public TestingArc testingArc;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.localScale += new Vector3(0.07f, 0.07f,0);

		GetComponent<SpriteRenderer>().color -= new Color(0,0,0,0.05f);
	}
}
