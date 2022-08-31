using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class EventSystem : MonoBehaviour
{
    public delegate void CollisionGold();
    public static event CollisionGold OnCollisionGold;

    private void Start()
    {
      
    }

}
