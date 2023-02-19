using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movethebean : MonoBehaviour
{ // Start is called before the first frame update
  // Start is called before the first frame update
    private float moveSpeed = 2;
    public float deadZone = 30;

    void Start()
    {
        moveSpeed = Constants.moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("position="+transform.position.y+" lawda="+(transform.position.y < deadZone));
        transform.position += ((Vector3.down * moveSpeed) * Time.deltaTime);
        if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
    }
}
