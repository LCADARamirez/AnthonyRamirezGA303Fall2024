using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float powerUpAmount;

    public PlayerRPG player;

    public float timer;
    public float respawnTime;

    public MeshRenderer meshRenderer;
    public Collider objectCollider;

    public bool hasBeenPickedUp = false;

    protected void Start()
    {
        player = FindFirstObjectByType<PlayerRPG>();
        meshRenderer = GetComponent<MeshRenderer>();
        objectCollider = GetComponent<Collider>();

    }

    protected void Update()
    {
        //The following code has been made obsolete with Coroutines!
        /*if (hasBeenPickedUp == true)
        {
            timer += Time.deltaTime;

            if (timer >= respawnTime)
            {
                meshRenderer.enabled = true;
                objectCollider.enabled = true;

                timer = 0f;
                hasBeenPickedUp = false;
            }
        }*/
    }

    protected void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PickUpPowerUp();
        }
    }

    protected virtual void PickUpPowerUp()
    {
        meshRenderer.enabled = false;
        objectCollider.enabled = false;

        StartCoroutine(WaitAndRespawnPowerUp());
    }

    protected IEnumerator WaitAndRespawnPowerUp()
    {
        yield return new WaitForSeconds(respawnTime);

        meshRenderer.enabled = true;
        objectCollider.enabled = true;
    }
}
