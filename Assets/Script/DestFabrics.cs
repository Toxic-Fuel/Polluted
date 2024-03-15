using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class FabricsDestroyed : MonoBehaviour
{
    public List<Fabrics> fb;
    public TMPro.TMP_Text Texts;
    int count=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void NewDestroyedFabric(Fabrics fab)
    {
       
          count+=fab.numDestroyedFabrics;
        
        Texts.text=count.ToString();
    }
}
