using UnityEngine;
using System.Collections;

public class SparkManager : MonoBehaviour {

	public float sizeScale;
	public VolumeChanger singleKey;

	// Use this for initialization
	void Start () {
	
		singleKey = GameObject.Find("SingleKey").GetComponent<VolumeChanger>();
		sizeScale = singleKey.volumeForce;
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.localScale += new Vector3(0.1f * sizeScale, 0.1f * sizeScale,0);

		GetComponent<SpriteRenderer>().color -= new Color(0,0,0,0.05f);
	}
		
}
