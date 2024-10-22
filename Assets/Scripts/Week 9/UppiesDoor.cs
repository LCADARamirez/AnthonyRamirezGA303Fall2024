using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UppiesDoor : Door
{
    public bool doesItUppies = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void OpenDoor()
    {
        base.OpenDoor();
        this.transform.Translate(Vector3.up * 5f);
    }
}
