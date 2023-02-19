using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdEnemySpawnerScript : MonoBehaviour
{
    public GameObject Bird;
    public float spawnTime = 7f;
    public float timer = 0f;
    void Start()
    {
        makeBird();

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

            makeBird();
            timer = 0;

        }
        // Debug.Log(timer);

    }

    void makeBird()
    {
        Instantiate(Bird, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation * (Quaternion.Euler(0, 0, 0)));
    }
}
