using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterBoat : MonoBehaviour
{
    public GameObject player;
    public GameObject Cam;
    public Transform objectA;
    public Transform objectB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(Cam.transform.position, Cam.transform.forward, out hit))
            {
                if (hit.distance < 5)
                {
                     objectA.position = objectB.position;
                     objectA.position = objectB.position + Vector3.down;
                     objectA.parent = objectB;
                }
            }
        }
    }
}
