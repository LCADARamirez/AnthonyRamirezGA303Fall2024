using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillJeff : MonoBehaviour //Doing this for Alannah
{
    public float timer;
    public float lifetime = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= lifetime)
        {
            Destroy(this.gameObject);
        }
    }
}
