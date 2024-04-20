using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Inevntory : MonoBehaviour
{
    public List<int> Resourses;
    public List<TMPro.TMP_Text> Texts;
    public int Stage=0;
    public Cheats cheat;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i<Resourses.Count; i++)
        {
            Resourses[i] = 0;
        }
        cheat = GameObject.Find("Canvas").GetComponent<Cheats>();

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
        if (cheat.hasCheat)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                Resourses[0] += 1;
                Resourses[3] += 1;
                Refresh();
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                Resourses[1] += 1;
                Resourses[4] += 1;
                Refresh();
            }
            if (Input.GetKeyDown(KeyCode.U))
            {
                Resourses[2] += 1;
                Resourses[5] += 1;
                Refresh();
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
       
    }
}
