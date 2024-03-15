using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int ItemInd;
    public GameObject LightS;
    public void SpecificTask(int ite)
    {
        if (ite == 0)
        {
            LightS.SetActive(true);
        }
    }
}
