using UnityEngine;
using System.Collections;

public class QueAndTip : MonoBehaviour {

    public GameObject Cue;
    private Vector3 offSet;
    public float speed;

    // Use this for initialization
    void Start()
    {
        offSet = transform.position - Cue.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Cue.transform.position + offSet;
    }
}
