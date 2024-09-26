using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;


public class Obstacle : MonoBehaviour
{
    void Awake()
    {
        Destroy(this.gameObject, 5); // destroy game object after 5 seconds
    } 

    void OnTriggerEnter2D(Collider2D other){

        if (other.CompareTag("Spaceship"))
        {
            Destroy(other.gameObject);  // destroy the spaceship
            SceneManager.LoadScene("MainMenu");  // load the main menu scene
        }
    }
}
