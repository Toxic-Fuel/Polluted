using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController rb;
    public float gravity;
    public float velocity = 2;
    public bool sprint = false;
    public bool isJumped = false;
    public float JumpHight = 5f;
    public int stamina = 100;
    

    void Start() {}

    Vector3 G;

    void Update()
    {
        stamina++;

        Vector3 Movement = Input.GetAxis("Horizontal") * transform.right + Input.GetAxis("Vertical") * transform.forward;
        rb.Move(Movement * velocity * Time.deltaTime);
        
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            velocity = 10;
            stamina -= 2;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            velocity = 4;
        }

        if (isJumped == false && Input.GetKeyDown(KeyCode.Space))
        {
            G.y = JumpHight;
            RaycastHit ray;
            if(Physics.Raycast(transform.position, -transform.up, out ray)){
                Debug.Log("Jump: " + ray.distance);
            }
            isJumped=true;
        }
        else
        {
            
            G.y += gravity * Time.deltaTime;
        }
        rb.Move(G * Time.deltaTime);
    }
    
}
