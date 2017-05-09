using UnityEngine;
using System.Collections;

/*
 * IMD CA2 Pool Game
 * Thomas Murray
 * X00115013
 */

namespace Game {
	public class nextTurn : AbstractGameObjectState {
		private PoolGameController game;
		private GameObject cue;
		private GameObject cueBall;
		private GameObject balls;
		private GameObject mainCamera;

		private Vector3 cameraOffset;
		private Vector3 cueOffset;
		private Quaternion cameraRotation;
		private Quaternion cueRotation;
        public Potted whosTurn;

		public nextTurn(MonoBehaviour parent) : base(parent) {
			game = (PoolGameController)parent;
			cue = game.cue;
			cueBall = game.cueBall;
			mainCamera = game.mainCamera;			
			cameraOffset = cueBall.transform.position - mainCamera.transform.position;
			cameraRotation = mainCamera.transform.rotation;
			cueOffset = cueBall.transform.position - cue.transform.position;
			cueRotation = cue.transform.rotation;
		}

		public override void FixedUpdate() {
				var cueBallmotion = cueBall.GetComponent<Rigidbody>();
            if (!(cueBallmotion.IsSleeping() || cueBallmotion.velocity == Vector3.zero))
            {
                return;
            }
            /*
            else
            {
                whosTurn = new Potted();

                if (whosTurn.player1Get() == true)
                {
                    whosTurn.player2Set(true);
                }
                else if (whosTurn.player2Get() == true)
                {
                    whosTurn.player1Set(true);
                }
            }
            

            whosTurn = new Potted();

            if (whosTurn.pottedGet() == true)
            {
                whosTurn.pottedSet(false);
            }
            */


            game.currentState = new cuePosition(game);


        }

		public override void LateUpdate() {
			mainCamera.transform.position = cueBall.transform.position - cameraOffset;
			mainCamera.transform.rotation = cameraRotation;
			
			cue.transform.position = cueBall.transform.position - cueOffset;
			cue.transform.rotation = cueRotation;
		}
	}
}