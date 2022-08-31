using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveMovment : MonoBehaviour
{
    SwerveInputSystem swerveInputSystem;
    [SerializeField] float SwerveSpeed = 0.5f;
    [SerializeField] float MaxSwerveAmount = 1;

    private void Awake()
    {
        swerveInputSystem = GetComponent<SwerveInputSystem>();

    }
    void Update()
    {
        float SwerveAmount = Time.deltaTime * SwerveSpeed * swerveInputSystem.MoveFactorX;
        SwerveAmount = Mathf.Clamp(SwerveAmount, -MaxSwerveAmount, MaxSwerveAmount);
        //var position = transform.localPosition;

        //if (position.x > swerveInputSystem.MoveFactorX)
        //{

        //    position.x = swerveInputSystem.MoveFactorX;
        //    transform.localPosition = position; 
        //}
        //else if (position.x < -swerveInputSystem.MoveFactorX)
        //{
        //    position.x = -swerveInputSystem.MoveFactorX;
        //    transform.localPosition = position;
           
        //}

        transform.Translate(SwerveAmount, 0, 0);
    }
}
