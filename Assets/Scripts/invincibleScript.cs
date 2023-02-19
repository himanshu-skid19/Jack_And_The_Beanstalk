using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invincibleScript : MonoBehaviour
{ public float invin = 10f;
    //public GameObject Player;
    private Constants Player;

    void Awake()
    {
        Player = GameObject.FindObjectOfType<Constants>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.CompareTag("Player"))
        {
            
            Debug.Log("powerup");
            Destroy(gameObject);
            Player.isInvinsible=true;
            Player.invinsibleTimer += invin;
        }


    }
}
