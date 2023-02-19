using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Constants : MonoBehaviour
{

    public static float moveSpeed = 2f;
    public static float speedIncrease = 0f;
    public bool isInvinsible = false;
    public float invinsibleTimer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeed += speedIncrease * (Time.deltaTime);
        //Debug.Log(moveSpeed);
    }
}
