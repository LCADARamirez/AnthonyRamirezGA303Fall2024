using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillJeff : MonoBehaviour //Doing this for Alannah (Also, this is a simple timer script that will destroy an object after it has been alive for a certain time.
{
    public float timer;         //The timer that will count up from 0 to the lifetime before Destroy() is called.
    public float lifetime = 5f; //The time we want this object to live.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; //Counts the timer up!

        if(timer >= lifetime)   //If the timer is at or above the lifetime we've set...
        {
            Destroy(this.gameObject);   //Destroy the object this script is on!
        }
    }
}
