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
        if (sb.value <= 0 && move.sprint == true)
        {
            sb.value = 0;
            move.stamina = 0;
            fillArea.SetActive(false);
        }
        else if(sb.value <= 0 && move.sprint == false)
        {
            sb.value = 0;
            
        }
        else
        {
            fillArea.SetActive(true);
        }

        sb.value = move.stamina;
    }

    void Update() {}
}
