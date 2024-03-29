using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moremovement : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)){
            Debug.Log("pressed the w key to move forwards");
            transform.position += new Vector3(0f,0f,1f);
        }
        if (Input.GetKeyDown(KeyCode.S)){
            Debug.Log("pressed the s key to move backwards");
            transform.position -= new Vector3(0f,0f,1f);
        }
        if (Input.GetKeyDown(KeyCode.A)){
            Debug.Log("pressed the a key to move to the left");
            transform.position -= new Vector3(1f,0f,0f);
        }
        if (Input.GetKeyDown(KeyCode.D)){
            Debug.Log("pressed the d key to move to the right");
            transform.position += new Vector3(1f,0f,0f);
        }
    }
}