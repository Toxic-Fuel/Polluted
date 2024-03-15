using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafting : MonoBehaviour
{
    public int ResourseIndex;
    public List<int> Price;
    public List<TMPro.TMP_Text> Texts;
    int Stage;
    public Inevntory inv;
    // Start is called before the first frame update
    void Start()
    {
        Stage = inv.Stage;


    }
    public void Buy()
    {
        if (inv.Resourses[Stage * 3] >= Price[0]&& inv.Resourses[(Stage * 3) +1] >= Price[1]&& inv.Resourses[(Stage * 3)+2] >= Price[2])
        {
            inv.Resourses[Stage * 3] -= Price[0];
            inv.Resourses[(Stage * 3) + 1] -= Price[1];
            inv.Resourses[(Stage * 3) + 2] -= Price[2];

        }
    }
}
