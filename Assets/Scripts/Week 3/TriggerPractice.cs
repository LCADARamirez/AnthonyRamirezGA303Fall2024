using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPractice : MonoBehaviour
{
    private AudioSource music;

    // Start is called before the first frame update
    void Start()
    {
        music = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) //Occurs when an object with a rigidbody enters the trigger collider of this object.
    {
        if(other.gameObject.tag == "JeffTag")
        {
            Debug.Log("Wow, it's Jeff! He's so strong!");
        }
    }

    private void OnTriggerExit(Collider other) //Occurs when an object with a rigidbody exits the trigger collider of this object.
    {
        if(other.gameObject.tag == "JeffTag")
        {
            music.Play();
            Debug.Log("Noooo don't leave me :(");
        }
    }

    private void OnTriggerStay(Collider other) //Occurs every frame an object is within the trigger collider of this object.
    {
        if(other.gameObject.tag == "JeffTag")
        {

        }
    }
}
