using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2FinishLine : MonoBehaviour
{
    void Start()
    {

    }


    void Update()
    {

    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("You win");
        }
    }
}
