using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCannon : MonoBehaviour
{
    public GameObject projectile;
    public Transform projectileSpawnPosition;
    public float speed = 750f;

    public void FireCannon()    //This is a function that can be called by others to fire this cannon.
    {
        GameObject go = Instantiate(projectile, projectileSpawnPosition.position, projectileSpawnPosition.rotation);

        go.GetComponent<Rigidbody>().AddForce(go.transform.forward * speed);
    }
}
