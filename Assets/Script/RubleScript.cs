using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubleScript : MonoBehaviour
{
    public GameObject Turbine;
   public void Replace()
    {
        Turbine.SetActive(true);
        Destroy(gameObject);
    }
}
