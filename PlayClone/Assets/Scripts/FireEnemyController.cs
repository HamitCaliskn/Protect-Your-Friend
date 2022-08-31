using UnityEngine;

public class FireEnemyController : MonoBehaviour
{
    [SerializeField] GameObject Target;
    [SerializeField] float distance;
    [SerializeField] float Maxdistance;
    //  public LayerMask playerLayer;

    Animator anim;
    private float RunnerDistance;

    void Start()
    {
        anim = GetComponentInChildren<Animator>();
    }
    void Update()
    {
        Fire();
    }

    private void Fire()
    {
        // Ray ray = cam.(new Vector3(0.5f, 0.5f, 0));
        //RaycastHit hit;
        //if (Physics.Raycast(transform.position, transform.forward, out hit, distance, playerLayer))
        //{
        //    anim.SetTrigger("Fire");
        //    transform.LookAt(Target.transform);
        //}

        distance = Vector3.Distance(transform.position, Target.transform.position);
        if (distance < Maxdistance)
        {
            anim.SetTrigger("Fire");
            transform.LookAt(Target.transform);
        }
    }
}
