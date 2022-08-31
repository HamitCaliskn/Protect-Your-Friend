using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Colision : MonoBehaviour
{
    EnemyController enemyController;
    NavMeshAgent navMeshAgent;
    [SerializeField] float StopDistance;
    Animator anim;
    [SerializeField] bool isCollision = false;
    private void Start()
    {
        enemyController = GetComponent<EnemyController>();
        navMeshAgent = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //transform.SetParent(collision.transform);
            enemyController.RunnerDistance = 150;
            navMeshAgent.stoppingDistance = StopDistance;
            anim.SetTrigger("Run");

            if (isCollision == false)
            {
                isCollision = true;
                FinishLine.instance.EnemyDance.Add(gameObject);
                 FinishLine.instance.EnemyAnimator.Add(anim);
                FinishLine.instance.EnemyNav.Add(navMeshAgent);
            }
        }
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        anim.SetTrigger("Box");
    //    }
    //}
}
