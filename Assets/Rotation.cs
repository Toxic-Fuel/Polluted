using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Vector2 rotation;
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
        transform.localRotation = Quaternion.Euler(-rotation.y, rotation.x,0);
    }
}
