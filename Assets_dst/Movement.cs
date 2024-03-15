using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float velocity=2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Movement = new Vector3 (Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
        rb.velocity = velocity * Movement;
        
    }
}
