using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   // defining a variable for direction
   private Vector3 direction;

    // defining the value of g which can be subject to change
    // if you want to vary the difficulty of the game
    public float gravity = -9.8f;    // -9.8 being the default value

    // again defining the strength of the jump which can be used to
    // increase or decrease difficulty
    public float strength = 3f;

    private float horizontalInput;
    private Rigidbody2D rigidbodyComponent;


    private BoxCollider2D coll;

    [SerializeField] private LayerMask jumpableGround;

   // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        

    }

    private void Update()
   {
        float dirX = Input.GetAxisRaw("Horizontal");
        rigidbodyComponent.velocity = new Vector2(dirX * 7f, rigidbodyComponent.velocity.y);

        if (Input.GetButtonDown("Jump") && isGrounded()){
            rigidbodyComponent.velocity = new Vector3(rigidbodyComponent.velocity.x, strength, 0);
        }

        
   }



   private bool isGrounded()
   {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, 0.1f, jumpableGround);
   }
}
