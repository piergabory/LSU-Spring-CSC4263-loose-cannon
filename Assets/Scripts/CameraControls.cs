using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{

    public int sensitivity = 10;
    public float speed = 1;

    // Camera position 
    public KeyCode moveForward;
    public KeyCode moveBackwards;
    public KeyCode moveLeft;
    public KeyCode moveRight;


    // Camera orientation
    public KeyCode lookUp;
    public KeyCode lookDown;
    public KeyCode lookLeft;
    public KeyCode lookRight;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Vector3 cameraTranslateControl = new Vector3(
            (Input.GetKey(moveLeft) ? -1 : 0) + (Input.GetKey(moveRight) ? 1 : 0),
            0,
            (Input.GetKey(moveForward) ? 1 : 0) + (Input.GetKey(moveBackwards) ? -1 : 0)
        );
        
        if (cameraTranslateControl.magnitude > 0.01) {
            transform.Translate(cameraTranslateControl * speed, Space.Self);
        }

        Vector3 cameraRotateControl = new Vector3(
            (Input.GetKey(lookUp) ? -1 : 0) + (Input.GetKey(lookDown) ? 1 : 0),
            (Input.GetKey(lookLeft) ? -1 : 0) + (Input.GetKey(lookRight) ? 1 : 0),
            0            
        );

        if (cameraRotateControl.magnitude > 0.01) {
            transform.Rotate(cameraRotateControl * sensitivity, Space.Self);
        }
    }   
}
