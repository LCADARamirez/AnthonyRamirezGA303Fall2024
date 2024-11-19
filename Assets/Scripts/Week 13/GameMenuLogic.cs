using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GameMenuLogic : MonoBehaviour
{
    public bool isMenuOpen = false;
    public GameObject menuObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isMenuOpen == false)
            {
                OpenMenu();
            }
            else
            {
                CloseMenu();
            }
        }
    }

    public void OpenMenu()
    {
        isMenuOpen = true;
        //menuObject.SetActive(true); //If you just want it to appear instead of scale, you can just do this.
        menuObject.transform.localScale = Vector3.zero;
        menuObject.transform.DOScale(1f, 0.5f);
    }

    public void CloseMenu()
    {
        isMenuOpen = false;
        //menuObject.SetActive(false); //If you just want it to disappear instead of scale, you can just do this.
        menuObject.transform.localScale = Vector3.one;
        menuObject.transform.DOScale(0f, 0.5f);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }
}
