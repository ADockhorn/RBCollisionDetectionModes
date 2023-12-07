using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class set_speed : MonoBehaviour
{
    public GameObject leftBall;
    public GameObject rightBall;
    public TMPro.TextMeshProUGUI label;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setSpeed(float speed)
    {
        label.text = speed.ToString();
        leftBall.GetComponent<bullet>().speed = speed;
        rightBall.GetComponent<bullet>().speed = speed;
    }
}
