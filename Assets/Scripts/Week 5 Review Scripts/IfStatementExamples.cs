using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatementExamples : MonoBehaviour
{
    public int numTimesPressedSpace = 0;
    public float currentTimer = 0f;
    public float resetTime = .5f;

    public bool hasPlayerDoublePressedSpace = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            numTimesPressedSpace++;

            if(hasPlayerDoublePressedSpace == true)
            {
                Debug.Log("Haha, you're pressing space again!");
            }
        }

        if(numTimesPressedSpace == 1)
        {
            currentTimer += Time.deltaTime;

            if(currentTimer >= resetTime)
            {
                currentTimer = 0f;
                numTimesPressedSpace = 0;
            }
        }

        if(numTimesPressedSpace == 2)
        {
            if(hasPlayerDoublePressedSpace == true)
            {
                Debug.Log("The space bar has been pressed twice again!");
            }

            if (hasPlayerDoublePressedSpace == false)
            {
                Debug.Log("The Space bar has been pressed twice for the first time!");
            }

            hasPlayerDoublePressedSpace = true;

            numTimesPressedSpace = 0;
            currentTimer = 0f;
        }
    }
}
