using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Fish : MonoBehaviour
{
    
    public float Speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
        
        Invoke("Despawn", 8f);
        
    }
    private void Update()
    {
        gameObject.transform.Translate(gameObject.transform.right * Time.deltaTime * Speed);
    }
    // Update is called once per frame
    void Despawn()
    {
        Destroy(gameObject);
    }
}
