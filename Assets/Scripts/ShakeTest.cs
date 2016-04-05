using UnityEngine;
using System.Collections;

public class ShakeTest : MonoBehaviour {

	private bool shaken;
	private Vector3 accelerationDirection = new Vector3(0,0,0);
	float currentAcceleration;

	void Start() {


	}

	void FixedUpdate() {

		Input.gyro.enabled = true;

		accelerationDirection.x = Input.gyro.userAcceleration.x ;

		accelerationDirection.y = Input.gyro.userAcceleration.y;

		if (accelerationDirection.sqrMagnitude > 0.005){

			accelerationDirection.Normalize();

		}

		Debug.Log (accelerationDirection.x);
			
		if (accelerationDirection.x > 0.1f)
		{
			currentAcceleration = accelerationDirection.x;

			shaken = true;
		}

		if (shaken)
		{
			if (accelerationDirection.x < currentAcceleration)
			{
				GetComponent<AudioSource>().volume = (currentAcceleration);
				GetComponent<AudioSource>().Play();
				shaken = false;
			}
		}

	}

}
