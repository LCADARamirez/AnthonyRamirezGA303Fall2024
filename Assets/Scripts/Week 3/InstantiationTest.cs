using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiationTest : MonoBehaviour
{
    public GameObject spawnedPrefab;    //This GameObject in the inspector should be set to the prefab in the project we want to spawn.

    public Transform otherSpawnLocation;    //This Transform in the inspector should be set to an empty object where you want the object to spawn. It will take the location of that object
                                            //and we will use this later to instantiate an object at the position of this Transform's position.

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(spawnedPrefab); //Instantiates an object at the position that the prefab says it will be.

        GameObject jeff = Instantiate(spawnedPrefab, this.transform.position, this.transform.rotation);   //Instantiates an object at the position of THIS object with the same rotation as THIS object

        jeff.GetComponent<Light>().color = Color.blue; //Here, we get reference to the Light component on the object we just created and have reference to, named 'jeff' and change its color to blue.

        jeff.AddComponent<AudioSource>(); //Here, we add a new component onto the object we have reference to (the object we just spawned). Here, we're adding an AudioSource.
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.W))
        {
            GameObject jeff = Instantiate(spawnedPrefab, otherSpawnLocation.position, otherSpawnLocation.rotation);

            jeff.GetComponent<Light>().color = Color.magenta;
        }
    }

    public void CreateJeff()
    {
        GameObject jeff = Instantiate(spawnedPrefab, this.transform.position, this.transform.rotation);

        jeff.GetComponent<Light>().color = Color.green;
    }
}
