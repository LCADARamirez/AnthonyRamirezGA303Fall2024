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
        
        if (otherObject.collider.gameObject.tag == "JeffTag")
        {
            Debug.Log("NOOOO! JEFF IS MY DOWNFALL!");
            Debug.Log("This flip was rated a " + (Random.Range(1, 10) + charismaModifier) + "/10");
            Destroy(this.gameObject, 2f);
        }
    }

    private void OnCollisionExit(Collision collision) //Called when an object STOPS colliding with it
    {
        
    }

    private void OnCollisionStay(Collision collision) // Called as long as an object continues to touch it.
    {
        
    }
}
