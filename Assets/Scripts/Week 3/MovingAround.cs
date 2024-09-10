using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAround : MonoBehaviour
{
    public Transform cubeTeleportTransform;
    public Transform cameraTransform;

    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        //this.transform.position = new Vector3(-5.46f, 4.38f);
        this.transform.position = cubeTeleportTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.Translate(Vector3.right * Time.deltaTime);  //This moves this transform one unit to the right per second
        //this.transform.position += Vector3.right * Time.deltaTime;   //This also moves this transform one unit to the right per second!

        if(Input.GetKeyDown(KeyCode.H))
        {
            this.transform.position = cameraTransform.position;         //Teleports this object to the position of the camera.
            this.transform.position += this.transform.forward * speed;  //Local forward depending on how the object is rotated.
            //this.transform.position += Vector3.forward;         //Universal forward (Z + 1)
        }
    }
}
