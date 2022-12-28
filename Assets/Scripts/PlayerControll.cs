using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float torqueAmount = 1f;
    Rigidbody2D rgd2d;
    // Start is called before the first frame update
    void Start()
    {
        rgd2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow)){

            rgd2d.AddTorque(torqueAmount);
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            rgd2d.AddTorque(-torqueAmount);
        }
    }
}
