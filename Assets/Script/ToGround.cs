using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToGround : MonoBehaviour
{
    public float Offset;
    // Start is called before the first frame update
    void Start()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, -transform.up, out hit))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - hit.distance-Offset, transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
