using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GameManager : MonoBehaviour
{
    [SerializeField] CharacterController characterController;
    [SerializeField] Animator anim;
    [SerializeField] float speed;
    [SerializeField] GameObject textAnim;

    [SerializeField] List<NavMeshAgent> navMeshAgents;
    [SerializeField] List<Animator> animators;

    bool isStart;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isStart)
        {
            characterController.Speed = speed;
            anim.SetTrigger("Run");
            textAnim.SetActive(false);
        }
        if (HealthBar.Instance.slider.value==0)
        {
            anim.SetTrigger("Die");
            characterController.Speed = 0;

            for (int i = 0; i < navMeshAgents.Count; i++)
            {
                NavMeshAgent nav = navMeshAgents[i];
                nav.speed = 0;
                EnemyAnimatorsSettings();
            }
        }
    }

    private void EnemyAnimatorsSettings()
    {
        for (int i = 0; i < animators.Count; i++)
        {
            Animator anim = animators[i];
            anim.SetTrigger("die");
        }
    }
}
