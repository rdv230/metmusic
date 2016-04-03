using UnityEngine;
using System.Collections;

public class rotationScr : MonoBehaviour {

	Gyroscope gyro;

	// Use this for initialization
	void Start () {
		gyro = Input.gyro;
		if(!gyro.enabled)
		{
			gyro.enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {

		gameObject.transform.rotation  = gyro.attitude;


	
	}
}
