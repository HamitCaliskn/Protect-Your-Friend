using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    GameObject Target;
    NavMeshAgent navMeshAgent;
    float distance;
    public float RunnerDistance;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        Target = GameObject.Find("Player");
    }


    void Update()
    {
        FollowPlayer();
    }
    //Player kovalama komutu
    public void FollowPlayer()
    {
        distance = Vector3.Distance(transform.position, Target.transform.position);
        if (distance < RunnerDistance)
        {
            navMeshAgent.isStopped = false;
            navMeshAgent.SetDestination(Target.transform.position);
            transform.LookAt(Target.transform);
            navMeshAgent.speed = 5;
        }


    }
}
