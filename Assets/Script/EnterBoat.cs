using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterBoat : MonoBehaviour
{
    public GameObject player;
    public GameObject Cam;
    public Transform objectA;
    public Transform objectB;
    bool isEntered=false;
    public Movement mov;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isEntered==false && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("abcd");
            RaycastHit hit;
            if (Physics.Raycast(Cam.transform.position, Cam.transform.forward, out hit))
            {
                if (hit.distance < 5 && hit.collider.gameObject.tag=="Boat")
                {
                     mov.isPlayerInBoat=true;
                     isEntered=true;
                     objectB.position=objectA.position+Vector3.up;
                     objectA.parent = objectB;
                }
            }
        }else if(isEntered==true && Input.GetKeyDown(KeyCode.E))
        {
                objectA.SetParent(null);
                isEntered=false;
        }
        if(isEntered==false)
        {
            mov.isPlayerInBoat=false;
        }
    }
}
