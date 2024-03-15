using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Resourse : MonoBehaviour
{
    public float MaxHealth;
    float Health;
    public int ResourseIndex;
    public Inevntory inv;
    
    // Start is called before the first frame update
    void Start()
    {
        Health = MaxHealth;
        inv = GameObject.Find("Player").GetComponent<Inevntory>();

    }
    public void TakeDamage(float dmg)
    {
        
        Health -= dmg;
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Health <= 0)
        {
            inv.Resourses[ResourseIndex] += 1;
            inv.Refresh();
            Destroy(gameObject);
        }
    }
}
