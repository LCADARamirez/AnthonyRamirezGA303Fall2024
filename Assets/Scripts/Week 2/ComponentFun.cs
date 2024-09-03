using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponentFun : MonoBehaviour
{
    public GameObject superCoolBallObject;

    public int counter = 0;
    public string myName;

    // Start is called before the first frame update
    void Start()
    {
        //superCoolBallObject = GameObject.Find("Spiderman"); // Finds the GameObject in the Heirarchy named
        //"Spiderman" _EXACTLY_ and sets a varaible reference to "superCoolBallObject".
        //superCoolBallObject now always refers to the object that was found named Spiderman.

        
        //GameObject.Find("Sphere").transform.SetParent(null);
        //superCoolBallObject.SetActive(false); //This sets the GameObject that is referred to by "superCoolBallObject" to disabled.
        //superCoolBallObject.SetActive(true); //This sets the GameObject that is referred to by "superCoolBallObject" to enabled.

        //gameObject.SetActive(false); //This would turn off the gameObject this script is attached to in the scene.
        //gameObject.SetActive(true); //This would turn on the gameObject this script is attached to in the scene.
        //gameObject.transform.
    }

    // Update is called once per frame
    void Update()
    {
        if(counter == 1) // if the counter variable is equal to 1, we will get dialog that says "Counter is 1!"
        {
            Debug.Log("Counter is 1!");
        }

        CheckInputs();

        //counter = counter + 3; //Increases the current value of counter by 3
        //counter += 3; //Increases the current value of counter by 3 (different syntax!)
        //counter -= 2; //Decreases the current value of counter by 2
        //counter = 0; //Sets the variable to 0.
    }

    void CheckInputs()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            counter++;
            Debug.Log("Counter is currently: " + counter);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            counter--;
            Debug.Log("Counter is currently: " + counter);
        }

        if (Input.GetKey(KeyCode.W))
        {
            Debug.Log("This is when the character would move!");
        }
    }
}
