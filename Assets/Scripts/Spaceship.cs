using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    Rigidbody2D rb;

    [Header("Movement")]
    [SerializeField] float speed = 10;

    void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector3 movement)
    {
        rb.MovePosition(transform.position + (movement * speed) * Time.fixedDeltaTime); // add position to current position
    }
}
