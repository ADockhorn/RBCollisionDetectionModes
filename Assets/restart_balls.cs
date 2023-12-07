using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restart_balls : MonoBehaviour
{
    public GameObject leftBall;
    public GameObject rightBall;
    public GameObject leftStartPosition;
    public GameObject rightStartPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Reset()
    {
        leftBall.transform.position = leftStartPosition.transform.position;
        rightBall.transform.position = rightStartPosition.transform.position;
        leftBall.GetComponent<bullet>().Reset();
        rightBall.GetComponent<bullet>().Reset();
    }
}
