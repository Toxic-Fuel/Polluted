using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inevntory : MonoBehaviour
{
    public List<int> Resourses;
    public List<TMPro.TMP_Text> Texts;
    public int Stage=0;
    // Start is called before the first frame update
    void Start()
    {
        Refresh();
    }
    void Refresh()
    {
        for (int i = 3; i > 0; i--)
        {
            Texts[i + (Stage * 3)].text = Resourses[i + Stage * 3].ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
