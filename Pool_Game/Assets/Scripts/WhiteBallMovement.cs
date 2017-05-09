using UnityEngine;
using System.Collections;

public class WhiteBallMovement : MonoBehaviour
{

    private Rigidbody rb, rb1;
    public GameObject QueTip;
    public GameObject WhiteBall;
    private Vector3 offSet;

    void Start()
    {
        rb = WhiteBall.GetComponent<Rigidbody>();
        //offSet = transform.position - WhiteBall.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float speed = rb.velocity.magnitude;
        if (speed < 5)
        {
            //StartCoroutine(Example());
            rb.velocity = new Vector3(0, 0, 0);
            rb1 = QueTip.GetComponent<Rigidbody>();
            if (speed == 0)
            {
                Vector3 gap = new Vector3(3, 0, 0);
                QueTip.transform.position = WhiteBall.transform.position + gap;
            }
            //rb1.mass = 3;
            
        }
        else if (speed > 1)
        {
            //StartCoroutine(Example());
            Vector3 notInUse = new Vector3(0, 100, 0);
            rb1 = QueTip.GetComponent<Rigidbody>();
            rb1.velocity = new Vector3(0, 0, 0);
            QueTip.transform.position = notInUse;
            rb1.mass = 0;
        }
    }  

    void Moving()
    {
    }

    IEnumerator Example()
    {
        print(Time.time);
        yield return new WaitForSeconds(5);
        print(Time.time);
    }
}
