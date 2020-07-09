using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionController : MonoBehaviour
{
    [SerializeField] private LayerMask clickableLayer;
    private GameObject mapGeneratorObject;
    private MapGenerator mapGeneratorScript;

    

    private void Start() 
    {
         mapGeneratorObject = GameObject.FindWithTag("map_generator");
         mapGeneratorScript = mapGeneratorObject.GetComponent<MapGenerator>();
    }

    void Update()
    {
        selectobject();
    }

    private void selectobject()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, Mathf.Infinity, clickableLayer))
            {
                //Tile.onClick.raycastHit.transform.gameObject;
                mapGeneratorScript.UpdateTile(raycastHit.transform.gameObject.transform.position);
                //Debug.Log("Raycast hit: " + raycastHit.transform.gameObject.transform.position);
                //Debug.Log("Raycast hit: " + raycastHit.collider.gameObject);
                //Tile tileScript = raycastHit.collider.GetComponent<Tile>();
                //tileScript.onClick();
            }
        }
    }
}
