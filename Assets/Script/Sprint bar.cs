using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;

public class Sprintbar : MonoBehaviour
{
    public GameObject fillArea;
    public Slider sb;
    public Movement move;
    public float sprint;

    void Start() {}

    public void Bar()
    {
        if (sb.value <= 0)
        {
            sb.value = 0;
            fillArea.SetActive(false);
        }
        else
        {
            fillArea.SetActive(true);
        }
    }

    void Update()
    {
        sb.value = move.stamina;
        Bar();
    }
}
