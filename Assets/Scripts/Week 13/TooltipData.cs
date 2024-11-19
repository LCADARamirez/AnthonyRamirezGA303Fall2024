using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TooltipData : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler //IPointerEnterHandler and IPointerExitHandler make it so you
                                                                                    //NEED to make an OnPointerEnter and OnPointerExit function in order
                                                                                    //to make it compile. BUT it also makes it so you know if something
                                                                                    //is hovering over this UI object or not.
{
    public string tooltipSentence;

    private TooltipLogic tooltipLogic;

    void Start()
    {
        tooltipLogic = FindFirstObjectByType<TooltipLogic>(); //This gets reference to the tooltipLogic script somewhere in the scene (there should only be one!)
    }

    public void OnPointerEnter(PointerEventData eventData) //This is called when the mouse is hovering over THIS object.
    {
        tooltipLogic.ShowTooltip(tooltipSentence); //This calls to the TooltipLogic script to make it appear and show the data that this object wants it to show (tooltipSentence)
    }

    public void OnPointerExit(PointerEventData eventData) //This is called when the mouse is no longer hovering over THIS object.
    {
        tooltipLogic.DisableTooltip(); //This calls to the TooltipLogic
    }
}
