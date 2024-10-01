using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public Transform initialSpawnPosition;
    public GameObject spawnPrefab;
    public int spawnCount = 0;
    //public Vector3 spaceBetweenCubes; //We set the direction it goes when we translate with this. (AAA)
    public int minRandomRange = -5;
    public int maxRandomRange = 5;

    // Start is called before the first frame update
    void Start()
    {
        SpawnCubes();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            SpawnCubes();
        }
    }

    void SpawnCubes()
    {
        for (int i = 0; i < spawnCount; i++)
        {
            int randomX = Random.Range(minRandomRange, maxRandomRange + 1);
            int randomY = Random.Range(minRandomRange, maxRandomRange + 1);
            //int randomZ = Random.Range(1, maxRandomRange + 1);

            Vector3 randomMoveDistance = new Vector3(randomX, randomY, 0);

            GameObject spawnedObject = Instantiate(spawnPrefab, initialSpawnPosition.position, initialSpawnPosition.rotation);

            //spawnedObject.transform.Translate(spaceBetweenCubes * i); (AAA)
            spawnedObject.transform.Translate(randomMoveDistance);
        }
    }
}
