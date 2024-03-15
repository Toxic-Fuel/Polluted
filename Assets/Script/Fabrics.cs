using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fabrics : MonoBehaviour
{
    public float FabricMaxHealth;
    float FabricHealth;
    public int numDestroyedFabrics=0;
    public FabricsDestroyed df;
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
            numDestroyedFabrics++;
            df.NewDestroyedFabric(this);

            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
