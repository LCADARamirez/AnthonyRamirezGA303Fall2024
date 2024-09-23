using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunshipExampleOne : MonoBehaviour  //This script is a way to do what for loops are doing, except this is really ineffective and is hardcoded how many cannons this ship has! Look at the Gunship.cs script for the PROPER way to do something like this!
{
    public NewCannon cannonOne;
    public NewCannon cannonTwo;
    public NewCannon cannonThree;  
    public NewCannon cannonFour;
    public NewCannon cannonFive;
    public NewCannon cannonSix;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            cannonOne.FireCannon();
        }
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            cannonTwo.FireCannon();
        }
        if(Input.GetKeyDown(KeyCode.Alpha3))
        { 
            cannonThree.FireCannon();
        }
        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            cannonFour.FireCannon();
        }
        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            cannonFive.FireCannon();
        }
        if(Input.GetKeyDown(KeyCode.Alpha6))
        {
            cannonSix.FireCannon();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            cannonOne.FireCannon();
            cannonTwo.FireCannon();
            cannonThree.FireCannon();
            cannonFour.FireCannon();
            cannonFive.FireCannon();
            cannonSix.FireCannon();
        }
    }
}
