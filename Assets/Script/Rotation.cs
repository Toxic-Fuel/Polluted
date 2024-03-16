using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    Vector2 rotation;
    public GameObject cam;
    public bool usesCont = false;
    public bool LockMode = true;
    public GameObject Inv;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (LockMode==true && Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("Locked");
            Cursor.lockState = CursorLockMode.None;
            Inv.SetActive(true);
            LockMode=false;
        }else if(LockMode==false && Input.GetKeyDown(KeyCode.I))
        {
            Debug.Log("Unlocked");
            Cursor.lockState = CursorLockMode.Locked;
            LockMode=true;
            Inv.SetActive(false);
        }
        if (!usesCont && LockMode==true)
        {
            
            rotation.x += Input.GetAxis("Mouse X") * 5;
            rotation.y += Input.GetAxis("Mouse Y") * 5;
            transform.localRotation = Quaternion.Euler(0, rotation.x, 0);
            cam.transform.localRotation = Quaternion.Euler(Mathf.Max(-90,Mathf.Min(90,-rotation.y)), 0, 0);
           
        }
        else
        {
            rotation.x += Input.GetAxis("JoyX") * 5;
            rotation.y += Input.GetAxis("JoyY") * 5;
            transform.localRotation = Quaternion.Euler(0, rotation.x, 0);
            cam.transform.localRotation = Quaternion.Euler(-rotation.y, 0, 0);
        }
        
    }
}
