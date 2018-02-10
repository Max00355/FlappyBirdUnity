using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D c) {
		Debug.Log (Time.deltaTime +  " Collided with " + c.name);
		Destroy (gameObject);
	}
}
