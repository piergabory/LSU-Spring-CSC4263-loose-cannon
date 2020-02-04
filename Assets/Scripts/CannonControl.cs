using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonControl : MonoBehaviour
{

    public float tiltSensitivity = 1.0f;
    public float aimSensitivity = 1.0f;

    public KeyCode shiftLeft;
    public KeyCode altshiftLeft;
    public KeyCode shiftRight;
    public KeyCode shiftUp;
    public KeyCode altshiftUp;
    public KeyCode shiftDown;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        JointSpring spring = GetComponent<HingeJoint>().spring;

        float tiltControl = ((Input.GetKey(shiftUp) || Input.GetKey(altshiftUp)) ? 1 : 0) + (Input.GetKey(shiftDown) ? -1 : 0);
        tiltControl *= tiltSensitivity;
        spring.targetPosition += tiltControl;        
        GetComponent<HingeJoint>().spring = spring;

        float aimControl = (Input.GetKey(shiftRight) ? 1 : 0) + ((Input.GetKey(shiftLeft) || Input.GetKey(altshiftLeft)) ? -1 : 0);
        aimControl *= aimSensitivity;
        transform.Rotate( 0 , aimControl, 0 );
    }
}
