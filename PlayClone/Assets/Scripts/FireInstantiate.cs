using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireInstantiate : MonoBehaviour
{
    public GameObject BulletPrefab;

    [SerializeField] float GizmosDrawLine;
    [SerializeField] GameObject BulletPoint;
    public Bullet bullet;


    [SerializeField] float BulletSpeed;
    [SerializeField] float EndTime;
    [SerializeField] Transform target;
    Vector3 pos;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 direction = transform.TransformDirection(Vector3.forward * GizmosDrawLine);
        Gizmos.DrawRay(transform.position, direction);
    }

    private void Instantiate()
    {
        Instantiate(BulletPrefab, BulletPoint.transform.position, BulletPoint.transform.rotation);
        pos.z =target.transform.position.z;
        transform.position = Vector3.MoveTowards(transform.position, pos, BulletSpeed * Time.deltaTime);
    }
}
