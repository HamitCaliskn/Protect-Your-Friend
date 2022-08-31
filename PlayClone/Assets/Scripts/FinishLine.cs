using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.AI;

public class FinishLine : MonoBehaviour
{
    public static FinishLine instance;

    Animator CharacterAnim;
    public List<GameObject> EnemyDance;
    public Animator EnemyAnim;
    public List<Animator> EnemyAnimator;
    public List<NavMeshAgent> EnemyNav;
    CharacterController characterController;
    [SerializeField] List<Animator> EndAnimators;

    private void Awake()
    {
        instance = this;
        characterController = GameObject.Find("Player").GetComponent<CharacterController>();
        CharacterAnim = GameObject.Find("Player").GetComponentInChildren<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        // Invoke("EnemyDances", 3f);
        StartCoroutine(EnemyDances());
    }

    IEnumerator EnemyDances()
    {
        yield return new WaitForSeconds(5f);
        foreach (var item in EnemyAnimator)
        {
            item.SetTrigger("DANCE");
            
        }
        EnemyStoped();
        PlayerStoped();
        EndPlayerAnimatorControllers();
    }
    //private void EnemyDances()
    // {
    //     foreach (var item in EnemyAnimator)
    //     {
    //         item.SetTrigger("DANCE");
    //     }
    // }

    private void EnemyStoped()
    {
        for (int i = 0; i < EnemyNav.Count; i++)
        {
            NavMeshAgent enemys = EnemyNav[i];
            enemys.isStopped = false;
            enemys.speed = 0;
            enemys.autoBraking = true;
        }
    }
    private void PlayerStoped()
    {
        characterController.Speed = 0;
        CharacterAnim.SetTrigger("Dance");
    }
    private void EndPlayerAnimatorControllers()
    {
        for (int i = 0; i < EndAnimators.Count; i++)
        {
            Animator EndAnimator = EndAnimators[i];
            EndAnimator.SetTrigger("Dance");
        }
    }
}
