using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{   
    private float cameraSpeed = 15.0f;
    private float panBorderThickness = 20f;
    private Vector2 panLimit;
       
    void Update () {

        handleCameraTransform();

    }
     

    private void handleCameraTransform()
    {
        Vector3 cameraPosition = transform.position;

        if(Input.GetKey(KeyCode.W) || Input.mousePosition.y >= Screen.height - panBorderThickness)
        {
            cameraPosition.z += cameraSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S) || Input.mousePosition.y <= panBorderThickness)
        {
            cameraPosition.z -= cameraSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D) || Input.mousePosition.x >= Screen.width - panBorderThickness)
        {
            cameraPosition.x += cameraSpeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A) || Input.mousePosition.x <= panBorderThickness)
        {
            cameraPosition.x -= cameraSpeed * Time.deltaTime;
        }
 
        cameraPosition.x = Mathf.Clamp(cameraPosition.x, 3, 31);
        cameraPosition.z = Mathf.Clamp(cameraPosition.z, -10, 20);

        transform.position = cameraPosition;
    }

    private void handleCameraZoom()
    {
        Vector3 cameraZoom = transform.position;
        
        if(Input.mouseScrollDelta.y > 0)
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y - 1f,transform.position.z + 0.84f);
        }
        if(Input.mouseScrollDelta.y < 0)
        {
            GetComponent<Transform>().position = new Vector3(transform.position.x, transform.position.y + 1f,transform.position.z - 0.84f);
        }

        //transform.position.y = Mathf.Clamp(transform.position.y, 5f, 15f);
        //transform.position.y = Mathf.Clamp(transform.position.y, 5f, 15f);
        
    }

}