using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastFun : MonoBehaviour
{

    public Transform cameraTransform;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(cameraTransform.position, cameraTransform.forward);
        

        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;

            if(Physics.Raycast(cameraTransform.position, cameraTransform.forward, out hit))
            {
                Debug.Log(hit.collider.gameObject.name);

                if (hit.collider.tag == "Cuber")
                {
                    Debug.Log("I've hit a cube!");
                    hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
                }

                if(hit.collider.tag == "Sphere")
                {
                    Debug.Log("I've hit a sphere!");
                    hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.green;
                }

                if(hit.collider.tag == "Cylinder")
                {
                    Debug.Log("I've hit a cylinder!");
                    hit.collider.gameObject.GetComponent<MeshRenderer>().material.color = Color.blue;
                }
            }
        }
    }
}
