using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwerveInputSystem : MonoBehaviour
{
    float lastFingerPosiziyonX;
    float moveFactorX;
    public float MoveFactorX => moveFactorX;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastFingerPosiziyonX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButton(0))
        {
            moveFactorX = Input.mousePosition.x - lastFingerPosiziyonX;
            lastFingerPosiziyonX = Input.mousePosition.x;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            moveFactorX = 0;
        }
    }
}
