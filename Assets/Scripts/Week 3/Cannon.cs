using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject cannonBall; //This will be our object we spawn.
    public Transform cannonBallSpawnLocation; //This is where our cannonball will spawn

    public float cannonBallSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(cannonBall, cannonBallSpawnLocation.position, cannonBallSpawnLocation.rotation);

            go.GetComponent<Rigidbody>().AddForce(go.transform.up * cannonBallSpeed);
        }
    }
}
