using UnityEngine;
using System.Collections;

/*
 * IMD CA2 Pool Game
 * Thomas Murray
 * X00115013
 */

public class SnookerBallController : MonoBehaviour {
	void Start() {
		GetComponent<Rigidbody>().sleepThreshold = 0.15f;
	}

	void FixedUpdate () {
		var rigidbody = GetComponent<Rigidbody>();
		if (rigidbody.velocity.y > 0) {
			var velocity = rigidbody.velocity;
			velocity.y *= 0.9f;
			rigidbody.velocity = velocity;
		}
	}
}
