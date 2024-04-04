using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceship : MonoBehaviour
{
    Rigidbody rb;
    public float acc = 0.5f;
    void Start()
  {
     rb = GetComponent<Rigidbody>();

  }
  void FixedUpdate()
  {  
    if (Input.GetKey(KeyCode.W))
    {
    rb.AddForce(0f,0f, acc);

    }
    if (Input.GetKey(KeyCode.S))
    {
    rb.AddForce(0f,0f, -acc);

    }
    if (Input.GetKey(KeyCode.A))
    {
    rb.AddForce(-acc,0f, 0f);

    }
    
    if (Input.GetKey(KeyCode.D))
    {
    rb.AddForce(acc,0f, 0f);

    }
  }
}
