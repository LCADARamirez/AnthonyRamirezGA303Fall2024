using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    [SerializeField] private string myName;
    [SerializeField] private int age;
    [SerializeField] private string favoriteMovie;
    [SerializeField] private string profession;
    [SerializeField] private string embarrassingMoment;
    [SerializeField] private string introductionDialog;
    

    public Color hairColor;
    // Start is called before the first frame update
    void Start()
    {
        IntroduceSelf();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IntroduceSelf()
    {
        Debug.Log(introductionDialog);
    }

    public string GetName() //This is a value returning function. We can return anything of type string here,
                            //and whatever calls this function will have read only access to the variable.
    {
        return myName;
    }

    public void ChangeName(string newName) //This is a function that will change a private variable within this script
                                            //From a function that can be called by another script. This is only used
                                            //in cases of needing to change private variables at some point, but requires code
                                            //to run.
    {
        myName = newName;
    }
}
