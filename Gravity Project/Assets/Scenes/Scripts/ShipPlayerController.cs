using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipPlayerController : MonoBehaviour
{

    public float baseSpeed = 100.0f;
    public float speedBoost = 150.0f;
    public float decreaseSpeed = -75.0f;
    public float speed;

    public Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = baseSpeed;
        rb.AddForce(transform.up * speed);
    }

    // Update is called once per frame
    void Update()
    {
        //checks if the boost should be activated by mouse down
        if (Input.GetMouseButtonDown(0) && speed < 150.0f)
        {
            speed = speedBoost;
            rb.AddForce(transform.up * speed);
        }

        //if mouse is not pressed boosting is false
        else if((!Input.GetMouseButtonDown(0)) && speed > 100.0f)
        {
            speed = decreaseSpeed;
            rb.AddForce(transform.up * speed);
        }

    }

}
