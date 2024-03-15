using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float maxHealth = 100;
    public Slider sl;
    public GameObject FillArea;
    float health;
    public bool gameOver = false;

    void Start() {
        health = maxHealth;
    }

    public void TakeDam(float dmg)
    {
        Debug.Log("hurka");
        health -= dmg;
        sl.value = health;
        if(health <= 0)
        {
            health = 0;
            gameOver = true;
        }
        
    }

    void Update()
    {
        
    }
}
