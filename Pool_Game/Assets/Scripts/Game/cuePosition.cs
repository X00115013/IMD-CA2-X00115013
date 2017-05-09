using UnityEngine;
using System.Collections;

/*
 * IMD CA2 Pool Game
 * Thomas Murray
 * X00115013
 */

namespace Game
{
    public class cuePosition : AbstractGameObjectState
    {
        private GameObject cue;
        private GameObject cueBall;
        private GameObject mainCamera;
        public Potted whosTurn;

        private PoolGameController game;

        public cuePosition(MonoBehaviour parent) : base(parent)
        {
            game = (PoolGameController)parent;
            cue = game.cue;
            cueBall = game.cueBall;
            mainCamera = game.mainCamera;
            cue.GetComponent<Renderer>().enabled = true;
        }

        public override void Update()
        {
            var x = Input.GetAxis("Horizontal");
            if (x != 0)
            {
                var angle = x * 90 * Time.deltaTime;
                game.cueBallDirection = Quaternion.AngleAxis(angle, Vector3.up) * game.cueBallDirection;
                mainCamera.transform.RotateAround(cueBall.transform.position, Vector3.up, angle);
                cue.transform.RotateAround(cueBall.transform.position, Vector3.up, angle);
            }

            if (Input.GetButtonDown("Fire1"))
            {
                game.currentState = new Game.cueSpeed(game);

                whosTurn = new Potted();

                if (whosTurn.pottedGet() == true)
                {
                    whosTurn.pottedSet(false);
                }
            }
        }
    }
}