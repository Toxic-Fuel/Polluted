using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cheats : MonoBehaviour
{
    public bool hasCheat = false;
    public List<GameObject> texts;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject i in texts)
        {
            i.SetActive(hasCheat);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            hasCheat = !hasCheat;
            foreach (GameObject i in texts)
            {
                i.SetActive(hasCheat);
            }
        }
    }
}
