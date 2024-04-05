using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public List<GameObject> TheObjs;
    public List<float> Count;
    public int GlCount;
    public int x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnFish", 0f, 2f);

    }

    // Update is called once per frame
    void SpawnFish()
    {
        for (int f = 0; f < TheObjs.Count; f++)
        {
            for (int i = 0; i < Count[f] * GlCount; i++)
            {
                Vector3 Vec = new Vector3(Random.RandomRange(0, x), Random.RandomRange(gameObject.transform.position.y, y), Random.RandomRange(0, z));
                GameObject Fish = Instantiate(TheObjs[f], Vec, Quaternion.identity);
                Fish.transform.rotation = Quaternion.Euler(0, Random.RandomRange(0, 360), 0);

            }
        }
    }

    }
    public class ResourseItem
    {
        public GameObject Obj;
        public int Chance;
    }

