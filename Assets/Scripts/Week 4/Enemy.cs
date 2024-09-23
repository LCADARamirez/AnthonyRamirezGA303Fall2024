using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public ScoreManager scoreManager;   //This is our reference to an object in the scene that contains the ScoreManager script. If we call on this reference, we have access to any public variables and functions that the ScoreManager script has.

    // Start is called before the first frame update
    void Start()
    {
        //We need to get reference to the player. Here are a few ways to do that!
        player = GameObject.Find("Player"); //Find an object by its name in the scene.

        player = GameObject.FindGameObjectWithTag("Player"); //Find an object by its tag in the scene.

        //We need to get reference to the ScoreManager script so we can call a function from it later.
        scoreManager = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreManager>(); //Finds the GameObject and calls GetComponent to get the ScoreManager script reference.

        scoreManager = FindFirstObjectByType<ScoreManager>(); //This finds the script in the scene directly to get reference.
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Y))
        {
            DestroyEnemy();
        }
    }

    void DestroyEnemy()
    {
        scoreManager.IncreaseScore(); //This calls the IncreaseScore() function on the ScoreManager's script.


        Destroy(this.gameObject);
    }
}
