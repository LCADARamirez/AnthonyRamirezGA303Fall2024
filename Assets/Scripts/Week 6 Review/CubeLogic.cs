using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLogic : MonoBehaviour
{
    public float timeToDie = 3f;

    void Start()
    {
        Destroy(this.gameObject, timeToDie);
    }
}
