using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        //Change the scene to the one where we actually play the game
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        //Quit the game
        Application.Quit();
    }
}
