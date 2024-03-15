using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float Damage = 3;
    
    public GameObject Animatable;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit))
            {
                if (hit.distance < 5)
                {
                    if(hit.collider.gameObject.GetComponent<Resourse>() != null)
                    {
                        hit.collider.gameObject.GetComponent<Resourse>().TakeDamage(Damage);
             
                    }else if(hit.collider.gameObject.GetComponent<Fabrics>() != null)
                    {
                        hit.collider.gameObject.GetComponent<Fabrics>().HitFabric(Damage);
                    }
                }
            }
        }
        
    }
}
