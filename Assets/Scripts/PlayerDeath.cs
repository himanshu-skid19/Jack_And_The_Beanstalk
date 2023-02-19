using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour
{

    private Rigidbody2D rb;
    private Constants Player;

    void Awake()
    {
        Player = GameObject.FindObjectOfType<Constants>();
    }
    // public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy" ) && (!Player.isInvinsible))
        {
            die();
            Debug.Log("Bird hits");
            SceneManager.LoadScene(2);
        }

       
    }

    //!Constants.isInvincible
    private void die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        Debug.Log("Game Over");
    }

    public void Update()
    {
        float yCor = transform.position.y;
        if (yCor < -6.2f)
        {   die();
            SceneManager.LoadScene(2);
        }

        float xCor = transform.position.x;
        if (xCor < -12.2f || xCor>12.2f)
        {
            die();
            SceneManager.LoadScene(2);
        }

        if (Player .isInvinsible)
        {
            if(Player.invinsibleTimer > 0)
            {
                Player.invinsibleTimer -= Time.deltaTime;
            }
            else
            {
                Player.isInvinsible= false;
            }
        }
    }

}
