using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeathScript : MonoBehaviour
{
    public int health = 200;
    public GameObject Enemy;
   

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy1") || other.gameObject.CompareTag("Enemy2"))
        {
            health -= 50;

            Debug.Log("Enemy"+Enemy.name +"health  is " + health);
            if (health == 0)
            {
                GetComponent<Collider2D>().enabled = false;
                this.enabled = false;

            }
        }
    }
}
