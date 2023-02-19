using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnnewStalk : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Stalk;
    public float spawnTime = 5.15F;
    public float constSpawn = 5.15f;
    public float velocity = 2F;
    public float moveSpeed = Constants.moveSpeed;
    public float timer = 0;
    void Start()
    {
        makeStalk();

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

            makeStalk();
            timer = 0;

        }
       // Debug.Log(timer);

    }

    void makeStalk()
    {
        Instantiate(Stalk, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation * (Quaternion.Euler(0, 0, 0)));
    }
}
