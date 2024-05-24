using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDealsDamage : MonoBehaviour
{
    public float push = 10f;

    void OnTriggerEnter2D(Collider2D other)
    {
      //Checking if the enemy is in contact with the player
      if (other.CompareTag("Player"))
      {
         PlayerScript player = other.GetComponent<PlayerScript>();
         if (player != null)
         {
            //Player takes 6 damage
            player.TakeDamage(6);
         }
      }
   }
}
