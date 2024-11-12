using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentScript : MonoBehaviour
{
    public PlayerRPG player;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);

        if (player != null)
        {
            player.Attack(new BaseEnemy());

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetUpReferences()
    {
        player = FindFirstObjectByType<PlayerRPG>();
    }
}
