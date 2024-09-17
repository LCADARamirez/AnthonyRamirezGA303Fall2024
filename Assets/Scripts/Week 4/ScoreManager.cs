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

    public void IncreaseScore()
    {
        
        score++;
        Debug.Log("Score is being increased! Score is now: " + score);
    }

    public void ResetScore()
    {
        score = 0;
    }
}
