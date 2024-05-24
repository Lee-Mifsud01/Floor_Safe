using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    //Max health for enemy
    public int Health = 4; 
    //Keep record of enemy current health
    private int currentHealth; 

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = Health;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <=0)
        {
            //Enemy dies
            Dead();
            ScoreManager score = FindObjectOfType<ScoreManager>();
            score.AddScore(1);
        }
    }

    //Dead function which destroys the game object
    private void Dead()
    {
        Debug.Log("Enemy Dead");
        Destroy(gameObject);
    }

}
