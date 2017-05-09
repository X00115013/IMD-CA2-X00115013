using UnityEngine;
using System.Collections;

public class CameraScriptSnooker : MonoBehaviour {

    public GameObject WhiteBall;
    private Vector3 offSet;


    // Use this for initialization
    void Start()
    {
        offSet = transform.position - WhiteBall.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = WhiteBall.transform.position + offSet;
    }
}
