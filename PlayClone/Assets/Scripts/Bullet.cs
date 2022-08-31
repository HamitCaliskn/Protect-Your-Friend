using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float BulletSpeed;
    [SerializeField] float EndTime;
    [SerializeField] Transform yourTarget;

    public HealthController healthController;
    [SerializeField] int damage;
    Vector3 pos;
    void Start()
    {
        healthController = GameObject.Find("Player").GetComponent<HealthController>();
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * BulletSpeed;
        Destroy(gameObject, EndTime);
        // transform.LookAt(target.transform.position);
        //pos.x = yourTarget.transform.position.x;
        //pos.y = yourTarget.transform.position.y;
        //transform.position = Vector3.MoveTowards(yourTarget.transform.position, pos, BulletSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            healthController.TakeDamage(damage);

        }
    }

}
