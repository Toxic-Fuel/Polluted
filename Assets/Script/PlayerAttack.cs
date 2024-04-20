using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using Unity.Burst.CompilerServices;

public class PlayerAttack : MonoBehaviour
{
    public AudioSource Lightsaber_Swing;
    public float Damage = 3;
    bool lightsaber = false;
    float HarmDamage = 0;
    public float CooldownDuration = 1f;
    public float CooldownDuration2 = 0.2f;
    Stopwatch Timer = new Stopwatch();
    Stopwatch TimerAttack = new Stopwatch();
    public GameObject Animatable;
    public List<GameObject> weapons;
    public List<GameObject> anims;
    public TMPro.TMP_Text healthText;
    bool IsWithDrill = false;

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
            IsWithDrill = false;
            for (int f = 0; f < weapons.Count; f++)
            {
                if (f != i)
                {
                    lightsaber = true;
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
            IsWithDrill = true;
            for (int f = 0; f < weapons.Count; f++)
            {
                if (f != i)
                {
                    lightsaber = false;
                    weapons[f].SetActive(false);
                }
            }
            
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Animatable.GetComponent<Animator>().Play("Swing", 0);
            if (lightsaber == true)
            {
                Lightsaber_Swing.Play();
            }
            isHitting = true;
            Timer.Restart();
            Timer.Start();

            RaycastHit hit;
            if (
                Physics.Raycast(transform.position, transform.forward, out hit)
                && TimerAttack.ElapsedMilliseconds >= CooldownDuration2 * 1000
            )
            {
                TimerAttack.Restart();
                TimerAttack.Start();
                if (hit.distance < 5)
                {
                    UnityEngine.Debug.Log(CooldownDuration2 * 1000);
                    if (hit.collider.gameObject.GetComponent<Resourse>() != null)
                    {
                        hit.collider.gameObject.GetComponent<Resourse>().TakeDamage(Damage);
                        UnityEngine.Debug.Log("14");
                    }
                    else if (hit.collider.gameObject.GetComponent<Fabrics>() != null)
                    {
                        if (IsWithDrill)
                        {
                            hit.collider.gameObject.GetComponent<Fabrics>().HitFabric(Damage);
                        }
                        
                    }
                    else if (hit.collider.gameObject.GetComponent<MeleeAI>() != null)
                    {
                        hit.collider.gameObject.GetComponent<MeleeAI>().GetDamaged(HarmDamage);
                    }
                }
            }
        }
        RaycastHit info;
        if (
            Physics.Raycast(transform.position, transform.forward, out info)

        )
        {
            if (info.distance < 5)
            {
                Resourse resourse = info.collider.gameObject.GetComponent<Resourse>();
                if (resourse != null)
                {
                    healthText.gameObject.SetActive(true);
                    healthText.text = (resourse.Name + " Health: " + resourse.Health.ToString() + "/" + resourse.MaxHealth.ToString());
                }
                else if (info.collider.gameObject.GetComponent<Fabrics>() != null)
                {
                    Fabrics fabrics = info.collider.gameObject.GetComponent<Fabrics>();
                    healthText.gameObject.SetActive(true);
                    healthText.text = (fabrics.FactoryName + " Health: " + fabrics.FabricHealth.ToString() + "/" + fabrics.FabricMaxHealth.ToString());
                }

                else
                {
                    healthText.gameObject.SetActive(false);
                }
            }
            else { healthText.gameObject.SetActive(false);}
           
            
        }
        if (Timer.ElapsedMilliseconds >= CooldownDuration * 1000)
        {
            isHitting = false;
            Timer.Restart();
            Timer.Start();
        }
        if (isHitting == false)
        {
            Animatable.GetComponent<Animator>().Play("New State", 0);
        }
    }
}
