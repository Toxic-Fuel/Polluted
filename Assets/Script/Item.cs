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
            Debug.Log(GameObject.Find("Main Camera").transform.position.x + 0.6f);
            GameObject LightSab = Instantiate(LightS, new Vector3(GameObject.Find("Main Camera").transform.position.x, GameObject.Find("Main Camera").transform.position.y, GameObject.Find("Main Camera").transform.position.z), Quaternion.identity);
            
            LightSab.transform.position = new Vector3(LightSab.transform.position.x + 0.6f, LightSab.transform.position.y - 0.5f, LightSab.transform.position.z + 1f);
            LightSab.transform.SetParent(GameObject.Find("Main Camera").transform);
        }
    }
}
