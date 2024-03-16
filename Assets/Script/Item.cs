using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int ItemInd;
    public GameObject LightS;
    public GameObject Drill;
   
    public PlayerAttack pa;
    
    public FabricsDestroyed fd;
    public void SpecificTask(int ite)
    {
        if (ite == 0)
        {
            pa.weapons[0]=LightS;
        }
        if(ite == 1)
        {
            pa.weapons[1] = Drill;
        }
        if(ite == 2)
        {
            
            fd.NewTurbine();
        }
        
        if (ite == 5)
        {

            fd.NewTurbine();
        }
    }
}
