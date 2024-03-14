using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fabrics : MonoBehaviour
{
    public float FabricMaxHealth;
    float FabricHealth;
    // Start is called before the first frame update
    void Start()
    {
        FabricHealth = FabricMaxHealth;
    }
    public void HitFabric(float damage)
    {
        FabricHealth -= damage;
        if(FabricHealth<=0)
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}