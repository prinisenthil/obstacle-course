using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer mr;
    Rigidbody rb;
    [SerializeField] float timeToWait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        mr.enabled = false;
        rb.useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeToWait) 
        {
            mr.enabled = true;
            rb.useGravity = true;
        }
    }
}
