using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public List<string> dialog;
    public TextMeshProUGUI dialogBox;
    public int dialogIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        dialogBox.text = dialog[dialogIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Player Pressed Space!");

            if (dialogIndex +1 >= dialog.Count) //If we're about to go out of range, just tell us.
            {
                dialogBox.gameObject.SetActive(false);
                Debug.Log("dialogIndex is about to go out of range. Ending Update now");
            }
            else //else, just do the rest of the code
            {
                Debug.Log("Increasing dialogIndex!");
                dialogIndex++;

                dialogBox.text = dialog[dialogIndex];
                Debug.Log("Text in text box was just changed :)");
            }
        }
    }
}
