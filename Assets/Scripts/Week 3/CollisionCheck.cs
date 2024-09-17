using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour
{
    public int charismaModifier = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision otherObject) //OnCollisionEnter is called whenever there is a collision on this object.
    {
        Debug.Log("Something hit me and it's name is " + otherObject.collider.gameObject.name);
        
        if (otherObject.collider.gameObject.tag == "JeffTag") //Here, we check if the other object that hit this object is tagged as "JeffTag". If it is, then we will do some more things.
        {
            Debug.Log("NOOOO! JEFF IS MY DOWNFALL!");
            Debug.Log("This flip was rated a " + (Random.Range(1, 10) + charismaModifier) + "/10"); //Random.Range here returns an integer from 1 to 10. Then the "charismaModifier" variable
                                                                                                    //is added to it because we were giving the flip a score from 1-10 and wanted it to be random
                                                                                                    //for fun :).

            Destroy(this.gameObject, 2f);   //This will destroy the GameObject that is passed into the Destroy() function (in this case it's the gameObject this is attached to), and it will happen after 2 seconds.
        }
    }

    private void OnCollisionExit(Collision collision) //Called when an object STOPS colliding with it
    {
        
    }

    private void OnCollisionStay(Collision collision) // Called as long as an object continues to touch it.
    {
        
    }
}
