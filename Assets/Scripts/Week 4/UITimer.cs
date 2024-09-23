using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITimer : MonoBehaviour
{
    public float timer = 0;
    public float timerDuration = 10f;
    public TextMeshProUGUI timerText;   //This is the TextMeshPro Text component on an object. Any object as a child of the
                                        //Canvas object that has the TextMeshPro Text component on it will have access to the
                                        //text being displayed in the UI by calling this variable's name ".text" and assigning
                                        //it to something, like:
                                        //timerText.text = "Whatever you want!";
                                        //As long as you pass a string to it, whether you type it out directly in the code or
                                        //you have a string variable that has some text assigned to it, it will appear in the
                                        //UI.


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

        timerText.text = "Time: " + timer.ToString();   //Calling timerText.text will change the actual text being displayed on that referenced component
                                                        //in the UI with whatever is on the right side of the equal sign.
    }
}
