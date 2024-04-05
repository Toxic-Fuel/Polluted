using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public GameObject robo;
    public int numRobos=5;
    int numCurrRobos=0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRobo",0f,10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRobo()
    {
        if(numCurrRobos<numRobos){
            GameObject robot = Instantiate(robo,new Vector3(Random.Range(transform.position.x+20,transform.position.x-20),transform.position.y,Random.Range(transform.position.z+20,transform.position.z-20)),Quaternion.identity);
            robot.transform.rotation = Quaternion.Euler(0, Random.RandomRange(0, 360), 0);
            numCurrRobos++;
        }
    }
}
