using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDialogue : MonoBehaviour
{
    public string myName = "Scott Pilgrim";
    public int age = 25;
    public string profession = "Comic Book Writer";
    public string favoriteMovie = "Scott Pilgrim vs. The World";

    public GameObject elleObject;

    public int elleFriendshipPoint = 0;
    public int santaClausFriendshipPoint = 0;
    public int colonelSandersFriendshipPoint = 0;

    public Person elle;
    public Person santaClaus;
    public Person colonelSanders;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(elle.hairColor);
        Debug.Log(elle.GetName()); //Shows elle's name because we asked for it through a function.

        IntroduceSelf();

        elleObject.GetComponent<Person>().ChangeName("New name :)");

        elle.ChangeName("New Name again :)");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IntroduceSelf()
    {
        Debug.Log("Hello! My name is " + myName + ". It's nice to meet you!");
    }

    public void AskFavoriteMovie()
    {
        Debug.Log("Here is where we will ask the other person we're talking to what their favorite movie is");
    }

    public void AskEmbarrassingMoment()
    {
        Debug.Log("if we have 5 friendship points, we can ask about the embarrassing moment");
    }

    public void AskToShowImpressiveSkill()
    {
        Debug.Log("We will call on whatever impressiveSkill the person has!");
    }

    public void ComplimentOnSkill()
    {
        Debug.Log("This is called when the button for compliment skill is called. We can increase friendship points" +
            " if we call this");
    }

    public void ShareMyInterests()
    {
        Debug.Log("This is called when the button for ShareMyInterests is called. We can increase friendship points this way" +
            "as well.");
    }
}
