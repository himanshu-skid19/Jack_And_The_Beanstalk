using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibleGeneratorScript : MonoBehaviour
{
    public GameObject Bird;
    public float spawnTime = 10f;
    public float timer = 0f;
    public bool up=false;

    void Start()
    {
        makeBird(up);
        up=!up;

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnTime)
        {
            timer += Time.deltaTime;
        }
        else
        {

            makeBird(up);
            timer = 0;
            up = !up;

        }
        // Debug.Log(timer);

    }

    void makeBird(bool upi)
    {
        if (upi)
        {
            Instantiate(Bird, new Vector3(transform.position.x+5, transform.position.y, transform.position.z), transform.rotation * (Quaternion.Euler(0, 0, 0)));
        }
        else
        {
            Instantiate(Bird, new Vector3(transform.position.x -5, transform.position.y, transform.position.z), transform.rotation * (Quaternion.Euler(0, 0, 0)));
        }
    }
}
