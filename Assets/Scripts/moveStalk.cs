using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveStalk : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += ((Vector3.down * moveSpeed) * Time.deltaTime);
        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }
}
