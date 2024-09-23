using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private float score = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseScore() //If any scripts call this function, the private score variable will be increased on this script and the score will be displayed in a Debug.Log().
    {
        
        score++;
        Debug.Log("Score is being increased! Score is now: " + score);
    }

    public void ResetScore()
    {
        score = 0;
    }
}
