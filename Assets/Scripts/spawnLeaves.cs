using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnLeaves : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject upLeaf;
    public GameObject downLeaf;
    public float heightOffset=2F;
    public float sizeOffset=0.2F;
    public float timeOffset=0.2F;
    public float swapnTime=5F;
    public float tt=5F;
    public bool up=true;
    public float timer=3F;
    private float velocity = 2;
    void Start()
    {
        spawningLeaves(up);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer<swapnTime){
            timer+=Time.deltaTime;
        }
        else{
            up=!up;
            spawningLeaves(up);
            timer=0;
            swapnTime=(Random.Range(tt*(1-timeOffset),tt))*(velocity/ Constants.moveSpeed);
        }
        

    }

    void spawningLeaves(bool up){
        
        
       
        if(up){
            Instantiate(upLeaf,new Vector3(transform.position.x+3.6F,transform.position.y,transform.position.z+2),transform.rotation*(Quaternion.Euler(0,0,-75)));
        }
        else{
            Instantiate(downLeaf,new Vector3(transform.position.x-4,transform.position.y,transform.position.z+2),transform.rotation*(Quaternion.Euler(180,0,105)));
        }
    }
}
