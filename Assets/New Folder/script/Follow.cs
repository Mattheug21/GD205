using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follow : MonoBehaviour
{
    NavMeshAgent hamster;
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        hamster = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        hamster.destination = target.position;
        
    }
}
