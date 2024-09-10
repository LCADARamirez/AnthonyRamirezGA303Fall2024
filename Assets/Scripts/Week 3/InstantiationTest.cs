using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiationTest : MonoBehaviour
{
    public GameObject spawnedPrefab;

    public Transform otherSpawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(spawnedPrefab); //Instantiates an object at the position that the prefab says it will be.

        GameObject jeff = Instantiate(spawnedPrefab, this.transform.position, this.transform.rotation);   //Instantiates an object at the position of THIS object with the same rotation as THIS object

        jeff.GetComponent<Light>().color = Color.blue;

        jeff.AddComponent<AudioSource>();
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
