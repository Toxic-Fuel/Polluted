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
        for(int i = 0; i<Resourses.Count; i++)
        {
            Resourses[i] = 0;
        }
        

    }
    public void Refresh()
    {
        for (int i = 2; i >= 0; i--)
        {
            Texts[i + (Stage * 3)].text = Resourses[i + Stage * 3].ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            Resourses[0] += 1;
            Refresh();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            Resourses[1] += 1;
            Refresh();
        }
        if (Input.GetKeyDown(KeyCode.U))
        {
            Resourses[2] += 1;
            Refresh();
        }
    }
}
