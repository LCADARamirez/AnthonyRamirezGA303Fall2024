using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int numTimesOpened = 0;

    public bool isDoorLocked = false;

    public bool isDoorOpen = false;

    public bool isDoorCurrentlyOpening = false;

    protected float timer;
    public float doorOpenInterval = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        
    }

    public virtual void OpenDoor()
    {
        numTimesOpened++;

        isDoorOpen = !isDoorOpen;

        Debug.Log(this.gameObject.name + " has been opened " + numTimesOpened + " times!");
    }
}
