using UnityEngine;
using System.Collections;

/*
 * IMD CA2 Pool Game
 * Thomas Murray
 * X00115013
 */

namespace Game {
	public class cueSpeed : AbstractGameObjectState {
		private PoolGameController game;

		private GameObject cue;
		private GameObject cueBall;

		private float cueDirection = -1;
		//private float speed = 50;

		public cueSpeed(MonoBehaviour parent) : base(parent) { 
			game = (PoolGameController)parent;
			cue = game.cue;
			cueBall = game.cueBall;
		}

		public override void Update() {
			if (Input.GetButtonUp("Fire1")) {
				game.currentState = new Game.cueForce(game);
			}
		}

		public override void FixedUpdate () {
			var distance = Vector3.Distance(cue.transform.position, cueBall.transform.position);
			if (distance < PoolGameController.MIN_DISTANCE || distance > PoolGameController.MAX_DISTANCE)
				cueDirection *= -1;
			cue.transform.Translate(Vector3.down * game.speed * cueDirection * Time.fixedDeltaTime);
		}
	}
}