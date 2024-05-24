using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float life = 1;

    void Awake()
   {
        Destroy(gameObject, life);
   }

   void OnTriggerEnter2D(Collider2D other)
   {
      //If the bullet touches the enemy
      if (other.CompareTag("Enemy"))
      {
         EnemyHealth enemy = other.GetComponent<EnemyHealth>();
         if (enemy != null)
         {
            //Deal 1 damage
            enemy.TakeDamage(1); 
            Destroy(gameObject);
         }
      }
      //If the bullet touches the collider
      else if (other.CompareTag("Collider"))
      {
         Destroy(gameObject);
      }
   }
}
