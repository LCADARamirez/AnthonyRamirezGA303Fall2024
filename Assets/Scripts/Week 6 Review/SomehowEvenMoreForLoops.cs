using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomehowEvenMoreForLoops : MonoBehaviour
{
    public bool hasPlayerBeenEliminated = false;
    public bool isNextObjectHoneycomb = true;

    public List<string> dialog = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            DropFruit(1);
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            DropFruit(2);
        }
    }

    public void DropFruit(int numObjectsDropped)
    {
        for (int i = 0; i < 3; i++)
        {
            if(isNextObjectHoneycomb)
            {
                //Player is eliminated
                //Object in list is destroyed and removed from List
                hasPlayerBeenEliminated = true;
            }

            if(hasPlayerBeenEliminated == true)
            {
                //break; //Break means we want to "break" out of the loop right now.
                       //Do not pass go, do not go around again.
            }
            Debug.Log("Going through " + i + " times");
        }

        //Run the rest of the code after the break.
    }
}
