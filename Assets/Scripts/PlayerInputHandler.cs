using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] Spaceship playerShip;

    void FixedUpdate(){
        // Initialize Vector3:
        Vector3 movement = Vector3.zero;

        // Move Left:
        if (Input.GetKey(KeyCode.A))
        {
            movement += new Vector3(-1, 0, 0);
        }

        // Move Right:
        if (Input.GetKey(KeyCode.D))
        {
            movement += new Vector3(1, 0, 0);
        }

        // Move player ship:
        playerShip.Move(movement);
    }

    public Spaceship GetPlayerShip()
    {
        return playerShip;
    }
}
