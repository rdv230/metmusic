using UnityEngine;
using System.Collections;

public class AccelerometerInput : MonoBehaviour {


	void Update() {
		

		


		Vector3 acceleration = Vector3.zero;
		for (int i = 0; i < Input.accelerationEventCount; i++) {
			AccelerationEvent accEvent = Input.GetAccelerationEvent(i);
			acceleration += accEvent.acceleration ;
		}
		print(acceleration);
	}
}