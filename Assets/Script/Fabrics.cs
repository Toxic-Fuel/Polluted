using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fabrics : MonoBehaviour
{
    public float FabricMaxHealth;
    public float FabricHealth;
    public int numDestroyedFabrics=0;
    public FabricsDestroyed df;
    public GameObject Ruble;
    public List<GameObject> toDel;
    public string FactoryName;
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
            Ruble.SetActive(true);
            for(int i =0; i < toDel.Count;i++)
            {
                toDel[i].SetActive(false);
            }
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
