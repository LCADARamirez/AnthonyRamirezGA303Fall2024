using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannonBall; //This will be our object we spawn. Select a prefab in the inspector for the object you're trying to spawn.
    public Transform cannonBallSpawnLocation; //This is where our cannonball will spawn. We have an empty object in the scene that is placed exactly where we want it to spawn.

    public float cannonBallSpeed = 500f;    //This is used as a multiplier for the force we apply to the Rigidbody when we spawn the cannonball and want it to fire. This needs to be a large number,
                                            //for it to be noticeable.

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //Check to see if the left mouse button is being clicked (0 is left click, 1 is right click, 2 is middle click)
        {
            GameObject go = Instantiate(cannonBall, cannonBallSpawnLocation.position, cannonBallSpawnLocation.rotation); //Creates a local variable of type GameObject called "go".
                                                                                                                         //On the right side, the cannonBall prefab we have in the project
                                                                                                                         //is spawned, or "instantiated". we spawn it at an empty object's
                                                                                                                         //Transform.position that we have in the scene that has the position
                                                                                                                         //we want the cannonball to spawn at. We then set the rotation of
                                                                                                                         // the spawned object to match that of the spawn location's
                                                                                                                         //rotation as well.
                                                                                                                         // 
                                                                                                                         //The object that is spawned is gained reference to in code, stored in the
                                                                                                                         //"go" variable. So if we need access to the object we just spawned, we
                                                                                                                         //can refer to "go" and use it like "go.SetActive(false);" if we wanted
                                                                                                                         //it to disappear as soon as it spawned for example.
                                                                                                                         

            go.GetComponent<Rigidbody>().AddForce(go.transform.up * cannonBallSpeed);   //This uses the reference to "go" for the object that we just spawned, and tries to search that object
                                                                                        //for the Rigidbody component. Once we have reference to the Rigidbody component, we can call
                                                                                        //that Rigidbody's .AddForce(velocity) function, passing in a Vector3 and multiplying it by a speed
                                                                                        //to launch the spawned object in the direction we tell it to.
        }
    }
}
