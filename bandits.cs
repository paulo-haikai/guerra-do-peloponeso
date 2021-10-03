using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class bandits : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform[] waypoints;int waypointsIndex;
    Vector3 target;
    public int life = 100;
    public bool recebeDano = false;
    public Animator anim;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, target) <1) {
            IterateWaypointIndex();
            UpdateDestination();

        }

        if (recebeDano == true) {

            anim.SetFloat("toma", 0.02f);





        }
    }

    void UpdateDestination() 
    {
        target = waypoints[waypointsIndex].position;
        agent.SetDestination(target);
    }
    void IterateWaypointIndex() {
        waypointsIndex++;
        if(waypointsIndex==waypoints.Length) {

            waypointsIndex = 0;
        }


    }
}

