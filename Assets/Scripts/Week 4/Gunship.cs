using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunship : MonoBehaviour
{
    public List<NewCannon> cannons = new List<NewCannon>(); //This creates a list of NewCannons that can be referenced by the variable "cannons".
        // Just like other variables, after "public", the datatype needs to be put here. List<NewCannon> is the datatype. It's basically saying it's a datatype
        // of a List of the NewCannon scripts. In the inspector, we can plug in as many objects that have a NewCannon script on it, and we can refer to them by index (cannons[0] is the first reference in the list)

    public int currentlySelectedCannon = 0; //We will use this to refer to a specific index of the list of cannons later!

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(cannons.Count);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G))
        {
            FireCurrentlySelectedCannon();
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            IncreaseSelectedCannonNumber();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            DecreaseSelectedCannonNumber();
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            FireAllCannons();
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            FireOddCannons();
        }

        if(Input.GetKeyDown(KeyCode.V))
        {
            FireEvenCannons();
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            MoveAllCannonballs();
        }
    }

    public void FireCurrentlySelectedCannon()
    {
        cannons[currentlySelectedCannon].FireCannon();

    }

    public void IncreaseSelectedCannonNumber()
    {
        if (currentlySelectedCannon < cannons.Count - 1) // This checks if the current number is at the maximum it can be. If it counts any higher, it will go out of range!
        {
            currentlySelectedCannon++;
        }
    }

    public void DecreaseSelectedCannonNumber()
    {
        if (currentlySelectedCannon > 0) //This checks to make sure that currentlySelectedCannon never falls below 0!
        {
            currentlySelectedCannon--;
        }
    }
    
    public void FireAllCannons()
    {
        /*foreach (NewCannon santaClaus in cannons) //For every instance of NewCannon in our list called "cannons"...
        {
            santaClaus.FireCannon();
            Debug.Log("PK Fire!!!!");
        }*/

        for (int i = 0; i < cannons.Count; i++) //First, it creates a new local variable called i, and starts at 0 (for the index number!)
                                                //Then, comes a conditional. This for loop will continue looping until this condition is no longer met!
                                                //Lastly, at the end of the code block for this loop, i will increase by 1.
        {
            cannons[i].FireCannon();            //Calls the FireCannon function for the index of i in the list of cannons.

            Debug.Log("Fired cannon index " + i);
        }

        Debug.Log("All cannons have been fired");
    }

    public void FireOddCannons()
    {
        for (int i = 0; i < cannons.Count; i++) //First, it creates a new local variable called i, and starts at 0 (for the index number!)
                                                //Then, comes a conditional. This for loop will continue looping until this condition is no longer met!
                                                //Lastly, at the end of the code block for this loop, i will increase by 1.
        {
            if(i % 2 == 1) //If i divided by 2 has a remainder of 1, we know it's odd!
            {
                cannons[i].FireCannon();
                Debug.Log("Fired Cannon at index " + i);
            }
        }
    }

    public void FireEvenCannons()
    {

        for (int i = 0; i < cannons.Count; i++) //First, it creates a new local variable called i, and starts at 0 (for the index number!)
                                                //Then, comes a conditional. This for loop will continue looping until this condition is no longer met!
                                                //Lastly, at the end of the code block for this loop, i will increase by 1.
        {
            if (i % 2 == 0) //The modulus operation - returns the remainder of the first number divided by the second number
                            //If i divided by 2 has a remainder of 0, we know it's even!
            {
                cannons[i].FireCannon();
                Debug.Log("Fired Cannon at index " + i);
            }
        }
        
    }

    public void MoveAllCannonballs()
    {
        List<Rigidbody> cannonballs = new List<Rigidbody>(); //Creates a local variable of a list of RigidBodies that is only used in this function then deleted.

        //cannonballs.AddRange(FindObjectsByType<Rigidbody>(FindObjectsInactive.Exclude, FindObjectsSortMode.None)); //This will Add all Rigidbodies in the scene to this list except for the ones that are inactive objects.

        foreach(GameObject go in GameObject.FindGameObjectsWithTag("CubeProjectile")) //Finds all gameobjects with a tag of "CubeProjectile"...
        {
            cannonballs.Add(go.GetComponent<Rigidbody>()); //And adds the rigidbody component from each of those gameObjects and adds them to the list of Cannonballs
        }

        foreach(Rigidbody b in cannonballs)
        {
            if(b.gameObject.tag == "CubeProjectile")
            {
                if(b.velocity.y == 0f)  //This checks if the velocity of the rigidbody is staying still specifically on the y-axis. If it is...
                {
                    b.AddForce(Vector3.up * 1000f); //Add force to the object!

                }
            }
        }



    }
}
