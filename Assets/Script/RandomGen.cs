using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGen : MonoBehaviour
{
    public List<GameObject> TheObjs;
    public List<float> Count;
    public int GlCount;
    public int x, y;
    // Start is called before the first frame update
    void Start()
    {
        for(int f=0; f<TheObjs.Count; f++)
        {
            for (int i = 0; i < Count[f]*GlCount; i++)
            {
                Vector3 Vec = new Vector3(Random.RandomRange(0, x), 100, Random.RandomRange(0, y));
                GameObject CurRes = Instantiate(TheObjs[f], Vec, Quaternion.identity);
                CurRes.transform.rotation = Quaternion.Euler(0, Random.RandomRange(0, 360), 0);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public class ResourseItem
    {
        public GameObject Obj;
        public int Chance;
    }
}
