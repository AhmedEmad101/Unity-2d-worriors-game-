using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 500;
    public GameObject Player;
    
    public GameObject startPoint;
 
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
            health -= 100;
            
            
            Debug.Log("your health is " + health);
           
            if(health == 0)
            {
                Player.transform.position = startPoint.transform.position;
                health = 500;
            }

        }
    }
       
    }


