using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITimer : MonoBehaviour
{
    public float timer = 0;
    public float timerDuration = 10f;
    public TextMeshProUGUI timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= timerDuration)
        {
            timer = timerDuration;
        }

        timerText.text = "Time: " + timer.ToString();
    }
}
