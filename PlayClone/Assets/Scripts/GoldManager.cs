using System.Collections;
using System.Collections.Generic;
using UnityEditor.MPE;
using UnityEngine;

public class GoldManager : MonoBehaviour
{
    [SerializeField] private int turnSpeed;


    private void Update()
    {
        GoldReturn();
    }

    public void GoldReturn()
    {
        transform.Rotate(new Vector3(0, 1, 0), Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            ScoreUp();
        }
    }
    public void ScoreUp()
    {
        ScoreManager.Instance.ScoreUp(10);
    }
}