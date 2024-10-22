using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb; 

    void OnMove(InputValue value)
    {
        Vector2 dir = value.Get<Vector2>();
        rb.velocity = dir * 10; 
    }
}










