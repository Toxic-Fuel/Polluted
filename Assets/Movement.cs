using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController rb;
    public float gravity;
    public float velocity=2;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    Vector3 G;
    // Update is called once per frame
    void Update()
    {
        Vector3 Movement = Input.GetAxis("Horizontal")*transform.right + Input.GetAxis("Vertical")*transform.forward;
        rb.Move(Movement*velocity*Time.deltaTime);
        
        G.y += gravity * Time.deltaTime;
        rb.Move(G * Time.deltaTime);
        
    }
}
