using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerFun : MonoBehaviour
{
    public float timerCountingUp = 0f;  //The current time on the timer;
    public float timerDuration = 3f;    //The time we need to wait before the timer finishes.

    public bool isCountingUp = true;

    public InstantiationTest instantiateScript; //This is a reference to another script that is doing some instantiations. We will reference this later to call a function of InstantiationTest
                                                // called CreateJeff().

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isCountingUp == true)
        {
            timerCountingUp += Time.deltaTime; //Timer increases by the time between frames (at a rate of 1 second per second)
        }
        else if (isCountingUp == false)
        {
            timerCountingUp -= Time.deltaTime; //Timer decreases by the time between frames (at a rate of 1 second per second)
        }

        if (timerCountingUp >= timerDuration) //If the timer reaches above the timer duration...
        {
            this.transform.position += Vector3.right; //Move this object to the right by one unit.

            Debug.Log("Timer has reached " + timerDuration + " seconds!"); //Display a debug log
            timerCountingUp = timerDuration;                      //Reset the timer to the max duration so it can count down and not double dip into THIS if statement

            isCountingUp = false; //Change this bool to false so that earlier in Update, it will count down instead of up.

            instantiateScript.CreateJeff(); //Call to the instantiateScript and call the CreateJeff() function in it.
        }

        if(timerCountingUp <= 0f) //If the timer falls below 0...
        {
            this.transform.position -= Vector3.right; //Move this object to the left by one unit

            Debug.Log("Timer has counted down to 0!"); //Display a Debug Log
            timerCountingUp = 0f; //Reset the timer to 0 so it doesn't double dip into THIS if statement

            isCountingUp = true; //Change this bool to true so that earlier in Update, it will count up instead of down.

            instantiateScript.CreateJeff();
        }

        //Debug.Log(timerCountingUp);
    }
}
