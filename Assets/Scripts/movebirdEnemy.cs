using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebirdEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    private float moveSpeed = 2f;
    public float birdVelocity = 5f;
    private Constants Player;

    void Awake()
    {
        Player = GameObject.FindObjectOfType<Constants>();
    }
    void Start()
    {
        moveSpeed = Constants.moveSpeed;
    }

    // Update is called once per frame
    void Update()
    { Vector3 temp = transform.position;
        temp.y = (-1 * moveSpeed);
        temp.z = 0;
        temp.x = (-1 * birdVelocity);
        transform.position += ((temp) * Time.deltaTime);
        if (transform.position.x < -33f)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
         
        }

    }

     
}
