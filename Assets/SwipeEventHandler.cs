using UnityEngine;
using System.Collections;
using System;

public class SwipeEventHandler : MonoBehaviour {

	public enum SwipeDir{
		Up,
		Down,
		Right,
		Left
	}

	public static event Action<SwipeDir>Swipe;

	private bool isSwiping = false;
	private bool eventSent = false;
	private Vector2 lastPos;

	void Update () {

		if(Input.touchCount == 0){
			return;
		}

		if(Input.GetTouch(0).deltaPosition.sqrMagnitude != 0){
			if(!isSwiping){
				isSwiping = true;
				lastPos = Input.GetTouch(0).position;
				return;
			}else{
				if(!eventSent){
					if(isSwiping != null){
						Vector2 dir = Input.GetTouch(0).position - lastPos;

						if(dir.y > 0){
							Swipe(SwipeDir.Up);
							Debug.Log("Swiping Up!");
						}else if(dir.y < 0){
							Swipe(SwipeDir.Down);
							Debug.Log("Swiping Down!");
						}
					}
				}
			}


		}
	}
}
