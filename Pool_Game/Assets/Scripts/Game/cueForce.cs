using UnityEngine;
using System;

/*
 * IMD CA2 Pool Game
 * Thomas Murray
 * X00115013
 */

namespace Game {
	public class cueForce : AbstractGameObjectState {
		private PoolGameController game;		
		private GameObject cue;
		private GameObject cueBall;
		
		public cueForce(MonoBehaviour parent) : base(parent) { 
			game = (PoolGameController)parent;
			cue = game.cue;
			cueBall = game.cueBall;

			var force = game.maxForce - game.minForce;
			var distance = (Vector3.Distance(cue.transform.position, cueBall.transform.position) - PoolGameController.MIN_DISTANCE) / (PoolGameController.MAX_DISTANCE - PoolGameController.MIN_DISTANCE);
            game.force = force * distance + game.minForce;
		}

		public override void FixedUpdate () {
			var distance = Vector3.Distance(cue.transform.position, cueBall.transform.position);
			if (distance < PoolGameController.MIN_DISTANCE) {
				cueBall.GetComponent<Rigidbody>().AddForce(game.cueBallDirection * game.force);
				cue.GetComponent<Renderer>().enabled = false;
				cue.transform.Translate(Vector3.down * game.speed * Time.fixedDeltaTime);
				game.currentState = new Game.nextTurn(game);
			} else {
				cue.transform.Translate(Vector3.down * game.speed * -1 * Time.fixedDeltaTime);
			}
		}
	}
}