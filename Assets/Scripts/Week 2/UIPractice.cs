using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPractice : MonoBehaviour
{
    public Toggle toggleUI; //Reference to the Toggle component in the scene.
    public Image kirbyImage; //Reference to the kirby image in the scene.
    public Sprite someOtherSprite; //You can reference another sprite here to swap it out with another on an image!
    public Image beegYoshi;

    // Start is called before the first frame update
    void Start()
    {
        //kirbyImage.sprite = someOtherSprite;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (toggleUI.isOn) //isOn is a public variable of the Toggle component.
        {
            // += means adding to the current value of the thing to the left of it.
            kirbyImage.rectTransform.localScale += Vector3.one * Time.deltaTime; // Multiplying a value by Time.deltaTime is basically saying "per second"
        }
    }

    public void ChangedToggleValue(bool toggleValue)
    {
        /*if(toggleValue == true)
        {
            kirbyImage.gameObject.SetActive(true);
        }
        else if (toggleValue == false)
        {
            kirbyImage.gameObject.SetActive(false);
        }*/  //   /* will start a comment block and */ will end the comment block!

        //THE ABOVE IS THE SAME AS BELOW
        kirbyImage.gameObject.SetActive(toggleValue);
    }

    public void FlipBEEGYoshi()
    {
        beegYoshi.rectTransform.Rotate(new Vector3(0f, 180f, 0f));
    }
}
