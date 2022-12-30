using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    bool canMove = true;
    public float torqueAmount = 1f;
    [SerializeField] float boostUp = 30f;
    [SerializeField] float baseSpeed = 20f;

    Rigidbody2D rgd2d;
    SurfaceEffector2D surfaceEffector2D;
    // Start is called before the first frame update
    void Start()
    {
        rgd2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {
            RotatePlayer();
        RespondToBoost();
       
        }
    }
    public void DisableControls ()
    {
        canMove = false;
        surfaceEffector2D.speed =0;
    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostUp;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rgd2d.AddTorque(torqueAmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rgd2d.AddTorque(-torqueAmount);
        }
    }
}
