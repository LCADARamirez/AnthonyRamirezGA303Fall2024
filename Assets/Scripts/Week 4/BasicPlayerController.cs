using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicPlayerController : MonoBehaviour //This is a VERY simple script to get something moving.
{
    public float speed = 7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(transform.forward * -1 * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(transform.forward *  speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(transform.right * -1 * speed * Time.deltaTime);

        }
        if(Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(transform.right *  speed * Time.deltaTime);
        }
    }
}
