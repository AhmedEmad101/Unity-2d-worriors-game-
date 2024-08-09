using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 200;
    public GameObject Player;
    public GameObject Enemy;
    public static bool isHide = false;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            health -= 50;


            Debug.Log("Enemy health is " + health);

            if (health == 0)
            {
                Debug.Log("Enemy Died");
                isHide = true;
               
                GetComponent<BoxCollider2D>().enabled = false;
                this.enabled = false;
                Enemy.SetActive(false);
            }

        }
    }
}
