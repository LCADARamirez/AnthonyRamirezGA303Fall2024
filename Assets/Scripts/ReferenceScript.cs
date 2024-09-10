using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceScript : MonoBehaviour
{
    public Light lightRef;
    public SomeOtherScript santaClaus;

    // Start is called before the first frame update
    void Start()
    {
        santaClaus.MissusClaus();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
