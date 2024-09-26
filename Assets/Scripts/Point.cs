using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    [SerializeField] PlayerInputHandler playerInputHandler;

    void Awake()
    {
        Destroy(this.gameObject, 5); // destroy game object after 5 seconds
    } 

    void OnTriggerEnter2D(Collider2D other){
        // Debug.Log("Add a point!");

        playerInputHandler.IncrementPoint();

        Destroy(this.gameObject);
    }

    public void SetPlayerInputHandler(PlayerInputHandler playerInputHandler)
    {
        this.playerInputHandler = playerInputHandler;
    }
}
