using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public SoundEffects se;
    public float Damage = 3;
    float HarmDamage = 0;
    public float CooldownDuration = 1f;
    public float CooldownDuration2 = 0.2f;
    Stopwatch Timer= new Stopwatch();
    Stopwatch TimerAttack = new Stopwatch();
    public GameObject Animatable;
    public List<GameObject> weapons;
    public List<GameObject> anims;
    
    bool isHitting;
    // Start is called before the first frame update
    void Start()
    {
        TimerAttack.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            int i = 0;
            weapons[i].SetActive(true);
            Animatable = anims[i];
            Damage = 1;
            HarmDamage = 4;
            CooldownDuration2 = 1f;
            for (int f = 0; f < weapons.Count; f++)
            {
                if (f != i)
                {
                    weapons[f].SetActive(false);
                }
            }
        }
        if (Input.GetKeyDown("2"))
        {
            int i = 1;
            weapons[i].SetActive(true);
            Animatable = anims[i];
            Damage = 5;
            HarmDamage = 0;
            CooldownDuration2 = 0.2f;
            for (int f = 0; f<weapons.Count; f++)
            {
                if (f != i)
                {
                    weapons[f].SetActive(false);
                }
            }
        }
        
        if (Input.GetButtonDown("Fire1"))
        {
            Animatable.GetComponent<Animator>().Play("Swing", 0);
            se.play_sound();
            isHitting = true;
            Timer.Restart();
            Timer.Start();
            

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit) && TimerAttack.ElapsedMilliseconds >= CooldownDuration2 * 1000)
            {
                TimerAttack.Restart();
                TimerAttack.Start();
                if (hit.distance < 5)
                {

                    UnityEngine.Debug.Log(CooldownDuration2 * 1000);
                    if (hit.collider.gameObject.GetComponent<Resourse>() != null)
                    {
                        hit.collider.gameObject.GetComponent<Resourse>().TakeDamage(Damage);
                        
             
                    }else if(hit.collider.gameObject.GetComponent<Fabrics>() != null)
                    {
                        hit.collider.gameObject.GetComponent<Fabrics>().HitFabric(Damage);
                    }else if(hit.collider.gameObject.GetComponent<MeleeAI>() != null)
                    {
                        hit.collider.gameObject.GetComponent<MeleeAI>().GetDamaged(HarmDamage);

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
            
        }
    }
    
   
}
