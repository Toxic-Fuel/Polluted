using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float Damage = 3;
    public float CooldownDuration = 1f;
    Stopwatch Timer= new Stopwatch();
    public GameObject Animatable;
    bool isHitting;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Animatable.GetComponent<Animator>().Play("Swing", 0);
            isHitting = true;
            Timer.Restart();
            Timer.Start();
            

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


        if (Timer.ElapsedMilliseconds >= CooldownDuration * 1000)
        {
            isHitting = false;
            Timer.Restart();
            Timer.Start();
        }
        if (isHitting==false)
        {
            Animatable.GetComponent<Animator>().Play("New State", 0);
            UnityEngine.Debug.Log("a");
            
        }
    }
    
   
}
