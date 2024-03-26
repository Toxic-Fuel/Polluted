using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        health -= dmg;
        sl.value = health;
        if(health <= 0)
        {
            health = 0;
            FillArea.SetActive(false);
            gameOver = true;
            FillArea.SetActive(false);
            SceneManager.LoadScene(0);
        }
        else
        {
            FillArea.SetActive(true);
        }
        
    }

    void Update()
    {
        
    }
}
