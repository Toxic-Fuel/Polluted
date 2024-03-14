using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliding : MonoBehaviour
{
    public Movement move;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, -transform.up, out hit))
        {
            Debug.Log(hit.distance);
            if(hit.distance <= 1.11)
            {
                move.isJumped = false;
            }
             
            
        }
    }

   
}
