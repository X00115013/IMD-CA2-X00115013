using UnityEngine;
using System.Collections;


/*
 * IMD CA2 Pool Game
 * Thomas Murray
 * X00115013
 */


public class PoolGameController : MonoBehaviour {
	public GameObject cue;
	public GameObject cueBall;
	public GameObject balls;
	public GameObject mainCamera;
	public float maxForce;
	public float minForce;
	public Vector3 cueBallDirection;
	public const float MIN_DISTANCE = 27.5f;
	public const float MAX_DISTANCE = 32f;	
	public IGameObjectState currentState;
    public float speed;
    public float force;


	static public PoolGameController GameInstance {
		get;
		set;
	}

	void Start() {
        cueBallDirection = Vector3.forward;
		GameInstance = this;
		currentState = new Game.cuePosition(this);
	}

	
	void Update() {
		currentState.Update();
	}

	void FixedUpdate() {
		currentState.FixedUpdate();
	}

	void LateUpdate() {
		currentState.LateUpdate();
	}
}