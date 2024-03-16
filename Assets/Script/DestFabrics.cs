using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class FabricsDestroyed : MonoBehaviour
{
    public List<Fabrics> fb;
    public TMPro.TMP_Text Texts;
    public TMPro.TMP_Text Texts2;
    public GameObject WinScreen;
    int count=0;
    int countT = 0;
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

        count += fab.numDestroyedFabrics;

        Texts.text = count.ToString();
    }
    public void NewTurbine()
    {
        RaycastHit hit;
        if (Physics.Raycast(GameObject.Find("Main Camera").transform.position, GameObject.Find("Main Camera").transform.forward, out hit))
        {
           
            if (hit.distance < 5)
            {
                Debug.Log("U");
                if (hit.collider.gameObject.GetComponent<RubleScript>() != null)
                {
                    countT++;
                    hit.collider.gameObject.GetComponent<RubleScript>().Replace();
                    Texts2.text = countT.ToString();
                    if (countT == 3)
                    {
                        SceneManager.LoadScene(1);
                    }
                }
                
                
            }
        }
       
    }
}
