using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    Vector2 rotation;
    public GameObject cam;
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        rotation.x += Input.GetAxis("Mouse X") * 5;
        rotation.y += Input.GetAxis("Mouse Y") * 5;
        transform.localRotation = Quaternion.Euler(0, rotation.x, 0);
        cam.transform.localRotation = Quaternion.Euler(-rotation.y, 0, 0);
    }
}
