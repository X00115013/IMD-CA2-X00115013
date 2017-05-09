using UnityEngine;
using System.Collections;

public class QueAction : MonoBehaviour {
    /*
    private Rigidbody rb;
    public float speed;
    public GameObject QueTip;
    Transform Wball;
    public GameObject WhiteBall;
    public Transform sphere;
    public float turnSpeed = 45.0f;
    public float moveSpeed = 45.0f;
    private Transform center;

    // Use this for initialization
    void Start () {
        rb = QueTip.GetComponent<Rigidbody>();
        QueTip = GameObject.FindWithTag("QueTip");
        WhiteBall = GameObject.FindWithTag("WhiteBall");

        center = new GameObject().transform;
        center.parent = sphere;
        transform.parent = center;
    }
   
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveVertical, 0.0f, moveHorizontal);
        rb.AddForce(movement * speed);
    }
    
    public void addPower()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = 15;

        Vector3 movement = new Vector3(moveVertical, 0.0f, 0.0f);
        rb.AddForce(movement * speed);
    }

    public void setSpeed(float speedIn)
    {
        speed = speedIn;
    }

    public float maxX = 360.0f;

    public float minY = 360.0f;
    public float maxY = 360.0f;

    public float sensY = 100.0f;

    //float rotationY = 0.0f;
    /*
    public float smooth = 2.0F;
    public float tiltAngle = 30.0F;
    void Update()
    {
        //float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
        Quaternion target = Quaternion.Euler(tiltAroundX, 0, 0);
        QueTip.transform.rotation = Quaternion.Slerp(WhiteBall.transform.rotation, target, Time.deltaTime * smooth);
    }
    
        void FixedUpdate()
    {
        rotationY += Input.GetAxis("Horizontal");
        rotationY = Mathf.Clamp(rotationY, minY, maxY);
        transform.localEulerAngles = new Vector3(0, rotationY,0);

        //the sphere gameObject     

        Wball = WhiteBall.transform;
        QueTip.transform.RotateAround(Wball.position, transform.localEulerAngles, sensY * Time.deltaTime);
        }
     
     void FixedUpdate() {
         
         if (Input.GetKey(KeyCode.LeftArrow)) {
             QueTip.transform.Rotate (0.0f, -turnSpeed * Time.deltaTime, 0.0f);        
         }
         if (Input.GetKey(KeyCode.RightArrow)) {
            QueTip.transform.Rotate (0.0f, turnSpeed * Time.deltaTime, 0.0f);        
         }
         else if (Input.GetKey (KeyCode.UpArrow)) {
             Vector3 v3Axis = -Vector3.Cross (center.position - QueTip.transform.position, transform.forward);
             center.rotation = Quaternion.AngleAxis(moveSpeed    * Time.deltaTime, v3Axis) * center.rotation;
         }
         else if (Input.GetKey (KeyCode.DownArrow)) {
             Vector3 v3Axis = Vector3.Cross (center.position - QueTip.transform.position, transform.forward);
             center.rotation = Quaternion.AngleAxis(moveSpeed * Time.deltaTime, v3Axis) * center.rotation;
         }
     } 
     */
 }