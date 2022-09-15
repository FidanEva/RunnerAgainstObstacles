using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace RunnerAgainstObstacle.Scripts
{
    public class Obstacle : MonoBehaviour
    {

        PlayerMovement playerMovement;

        private void Start()
        {
            playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
        } 

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Player")
            {
                // Kill the player
                playerMovement.Die();
            }
        }
    }
}