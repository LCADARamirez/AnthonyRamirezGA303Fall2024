using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingDoor : Door
{
    public bool hasHandles = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    protected override void Update()
    {
        if(isDoorCurrentlyOpening)
        {
            timer += Time.deltaTime;

            if(timer >= doorOpenInterval)
            {
                timer = 0;
                isDoorCurrentlyOpening = false;
            }
        }
    }

    public override void OpenDoor()
    {
        if(isDoorCurrentlyOpening)
        {
            return;
        }

        base.OpenDoor();
        isDoorCurrentlyOpening = true;

        if(isDoorOpen == false)
        {
            this.transform.DOMoveX(this.transform.position.x + 5f, doorOpenInterval);

        }
        else
        {
            this.transform.DOMoveX(this.transform.position.x - 5f, doorOpenInterval);
        }
    }

    public void GreaseSlider()
    {

    }
}
