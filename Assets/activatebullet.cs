using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activatebullet : MonoBehaviour
{
    public GameObject rightBall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void deActivateBullet()
    {
        rightBall.SetActive(!rightBall.active);
    }

}
