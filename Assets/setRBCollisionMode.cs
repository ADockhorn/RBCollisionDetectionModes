using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setRBCollisionMode : MonoBehaviour
{
    public GameObject rightBall;
    public GameObject leftBall;
    public CollisionDetectionMode collisionDetectionMode;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setCollisionMode()
    {
        rightBall.GetComponent<Rigidbody>().collisionDetectionMode = collisionDetectionMode;
        leftBall.GetComponent<Rigidbody>().collisionDetectionMode = collisionDetectionMode;
    }
}
