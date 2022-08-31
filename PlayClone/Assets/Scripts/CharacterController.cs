using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] float SideSpeed;
    Animator CharacterAnim;

    public float Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value;
        }
    }
    private void Start()
    {
        CharacterAnim = GetComponentInChildren<Animator>();
    }
    void Update()
    {
        //Cursor.lockState = CursorLockMode.Locked; 
        Move();
    }

    private void Move()
    {
        transform.position += transform.forward * Time.deltaTime * Speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            CharacterAnim.SetTrigger("Box");
        }
    }


}



