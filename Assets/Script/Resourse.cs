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
    }
    public void TakeDamage(float dmg)
    {
        Health -= dmg;
        if(Health <= 0 ) {
            Destroy(gameObject);       
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
