using System.Collections;
using System.Collections.Generic;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class EnemyNav : MonoBehaviour
{
    public NavMeshAgent navAgent;
    public PlayerRPG player;

    public List<Transform> patrolPoints = new List<Transform>();
    public int patrolIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        navAgent = GetComponent<NavMeshAgent>();
        player = FindFirstObjectByType<PlayerRPG>();


        navAgent.SetDestination(patrolPoints[patrolIndex].position);

    }

    // Update is called once per frame
    void Update()
    {
        //navAgent.SetDestination(player.transform.position); //This will follow the player since it's in update with no boundaries set up

        if (Vector3.Distance(this.transform.position, player.transform.position) <= 8f)
        {
            Vector3 direction = (player.transform.position - this.transform.position).normalized;

            RaycastHit hit;

            if(Physics.Raycast(this.transform.position, direction, out hit, 8f))
            {
                if(hit.collider.tag == "Player")
                {
                    navAgent.SetDestination(player.transform.position);
                }
            }
        }


        if(navAgent.remainingDistance < .5f)
        {
            patrolIndex++;

            if(patrolIndex >= patrolPoints.Count)
            {
                patrolIndex = 0;
            }

            navAgent.SetDestination(patrolPoints[patrolIndex].position);
        }
    }
}
