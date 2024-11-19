using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerData : MonoBehaviour
{
    public static PlayerData instance; //This is a static variable, meaning when it's assigned, ANYTHING can access this by calling PlayerData.instance
                                       //to get reference to whichever object is assigned this instance (the first one created in most cases)

    public int playerHealth; //These 3 are example variables of things we want to keep between scenes.
    public int playerMoney;
    public int hatIndex;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)    //If the static variable of instance has not yet been set...
        {
            Debug.Log("There was no player before this, so let's set the instance to this one!");
            instance = this;    //Set this object that has this script to that instance!
        }
        else if (instance != null)  //If there's already an object assigned to instance...
        {
            Debug.Log("There's already an instance of a player, let's delete the new one!");
            Destroy(this.gameObject);   //Delete this one because it's a duplicate!
        }

        DontDestroyOnLoad(this.gameObject); //This command makes it so the object will not be unloaded/destroyed when loading another scene. All data stays here!
        SceneManager.sceneLoaded += OnSceneChanged; //This creates a listener that is called whenever the scene changes. Basically, we can call a function when Unity
                                                    //says "Hey! A scene has been loaded!".
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha5))    //Testing to quickly switch scenes for testing.
        {
            SceneManager.LoadScene("CombatScene");
        }
        if(Input.GetKeyDown(KeyCode.Alpha6))
        {
            SceneManager.LoadScene("GameScene");
        }
    }

    public void OnSceneChanged(Scene scene, LoadSceneMode mode) //This is the function being called when a new scene is loaded. The listener has to be set up (in Start())
                                                                //in order for this to be properly called.
    {
        if (scene.name == "ShopScene") //if the scene being loaded is called "ShopScene"...
        {
            //Do shop stuff that you need to do
        }
        else if (scene.name == "StartScene")    //if the scene being loaded is called "StartScene"...
        {
            Debug.Log("We're in the start scene! Time to destroy myself!");
            Destroy(this.gameObject);
        }
        else if(scene.name == "GameScene")  //if the scene being loaded is called "GameScene"...
        {
            //Reset the position of the player to the right place.
            Debug.Log("Gotta set my position back to my starting position!");
            this.transform.position = GameObject.FindGameObjectWithTag("PlayerStartPosition").transform.position;   //Find the object tagged with "PlayerStartPosition"
                                                                                                                    //and set this player object to that position!
        }
    }
}
