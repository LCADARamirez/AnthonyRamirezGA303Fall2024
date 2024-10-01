using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum JobType
{
    Fighter,
    Mage,
    Paladin,
    Monk,
    Healer
}

public class PlayerCharacter : MonoBehaviour
{
    public JobType playerJob;

    public int strengthStat;
    public int intelligenceStat;

    // Start is called before the first frame update
    void Start()
    {
        if(playerJob == JobType.Fighter)
        {
            strengthStat = 5;
            intelligenceStat = 2;
            Debug.Log("WAAAAAAAAAAluigi");
        }

        if (playerJob == JobType.Mage)
        {
            strengthStat = 10;
            intelligenceStat = 1;
            Debug.Log("Hello, I'm casting spells");
        }

        if(playerJob == JobType.Paladin)
        {
            Debug.Log("For the light!");
        }

        if(playerJob == JobType.Monk)
        {
            Debug.Log("*Punches you*");
        }

        if (playerJob == JobType.Healer)
        {
            Debug.Log("Nobody appreciates me");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
