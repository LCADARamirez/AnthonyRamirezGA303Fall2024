using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactersMover : MonoBehaviour
{
    public List<GameObject> players = new List<GameObject>();
    public int currentPlayerIndex = 0;

    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        players[currentPlayerIndex].transform.Translate(Vector3.right * speed * Time.deltaTime);


        if(Input.GetKeyDown(KeyCode.D))
        {
            if(currentPlayerIndex < players.Count - 1)
            {
                currentPlayerIndex++;
            }
            
        }

        if(Input.GetKeyDown(KeyCode.A))
        {
            if(currentPlayerIndex > 0)
            {
                currentPlayerIndex--;
            }
            
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Destroy(players[0]);
            players.RemoveAt(0);
        }
    }
}
