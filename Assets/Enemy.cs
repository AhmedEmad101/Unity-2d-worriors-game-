using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
     int currentHealth;
    void Start()
    {
        currentHealth = maxHealth;

        
    }
    public void takeDamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("Hurt");
        if(currentHealth <= 0)
        {
            die();
        }
    }
    public void die()
    {
        animator.SetBool("IsDead", true) ;
        Debug.Log("Enemy died");
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        
    }

    
}
