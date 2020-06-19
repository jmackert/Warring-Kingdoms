using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{   
    private float mainSpeed = 10.0f; //camera speed
    
    //float camSens = 0.25f; //How sensitive it with mouse

    //private Vector3 lastMouse = new Vector3(300, 300, 300); //kind of in the middle of the screen, rather than at the top (play)

     
    void Update () {

        /*lastMouse = Input.mousePosition - lastMouse ;
        lastMouse = new Vector3(-lastMouse.y * camSens, lastMouse.x * camSens, 0 );
        lastMouse = new Vector3(transform.eulerAngles.x + lastMouse.x , transform.eulerAngles.y + lastMouse.y, 0);
        transform.eulerAngles = lastMouse;
        lastMouse =  Input.mousePosition;*/
        //Mouse  camera angle done.  
       
        handleCameraZooom();
        Vector3 p = getBaseInput();
        p = p * mainSpeed;
        p = p * Time.deltaTime;
        Vector3 newPosition = transform.position;
            transform.Translate(p);
            newPosition.x = transform.position.x;
            newPosition.z = transform.position.z;
            transform.position = newPosition;      
    }
     
    private Vector3 getBaseInput() {
        Vector3 p_Velocity = new Vector3();
        if (Input.GetKey (KeyCode.W)){
            p_Velocity += new Vector3(0, 0 , 1);
        }
        if (Input.GetKey (KeyCode.S)){
            p_Velocity += new Vector3(0, 0, -1);
        }
        if (Input.GetKey (KeyCode.A)){
            p_Velocity += new Vector3(-1, 0, 0);
        }
        if (Input.GetKey (KeyCode.D)){
            p_Velocity += new Vector3(1, 0, 0);
        }
        return p_Velocity;
    }

    private void handleCameraZooom()
    {
        if(Input.mouseScrollDelta.y > 0)
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x + 1f, transform.position.y - 1.15f,transform.position.z + 1.73f);
        }
        if(Input.mouseScrollDelta.y < 0)
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x - 1f, transform.position.y + 1.15f,transform.position.z - 1.73f);
        }
    }

}