using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipLogic : MonoBehaviour
{
    public GameObject tooltipBox; //This is the entire box for the tooltip that we set active and inactive.
    public TextMeshProUGUI tooltipText; //This is the actual text of the tooltip that needs to be changed whenever we hover over an object.

    public bool isTooltipActive = false; //In update, this will allow us to do things while the tooltip is active or not

    // Update is called once per frame
    void Update()
    {
        if(isTooltipActive)
        {
            //tooltipBox follows the cursor and stays near it
            //Mouse.current.position.ReadValue() //For new unity input system instead of Input.mousePosition
            tooltipBox.transform.position = Input.mousePosition + new Vector3(225f, 125f); //This sets the position of the tooltip box to the mouse cursor, but also has an
                                                                                 //offset so it doesn't go directly on top of the cursor. You'll want the size of
                                                                                 //this to be about half the size of the tooltip box and a little more.
        }
    }

    public void ShowTooltip(string text) //This needs to be called whenever you need the tooltip to show. It needs a string to be passed for the
                                         //information you want to show on it.
    {
        tooltipBox.SetActive(true);
        tooltipText.text = text;
        isTooltipActive = true; //Setting this to true will allow update to move the position of the tooltip while one is active.
    }

    public void DisableTooltip()
    {
        tooltipBox.SetActive(false);
        isTooltipActive = false; //Setting this to false will stop the position of the tooltip from updating.
    }
}
