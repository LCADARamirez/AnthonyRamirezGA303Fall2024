using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimeEventPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake() //Awake is called before Start
    {

    }

    // Update is called once per frame (unlimited by framerate)
    void Update()
    {
        Debug.Log("Updating every frame!");
    }

    private void LateUpdate() //LateUpdate is called at the end of the frame (after Update()) (unlimited by framerate)
    {
        Debug.Log("Updating every frame right after update!");
    }

    private void FixedUpdate() //Updates at 30 frames per second always
    {
        Debug.Log("Updating 30 frames per second");
    }

    void OnEnable() //Called when the object is enabled from a disabled state. (Will be called after start if the object is active)
    {
        Debug.Log("Object is enabled!");
    }

    void OnDisable() //Runs all the code in this function right before it is disabled.
    {
        Debug.Log("Object is disabled!");
    }

    private void OnDestroy() //Runs all the code in this function right before it is destroyed.
    {
        Debug.Log("This object is being destroyed! oh no!");
    }
}
