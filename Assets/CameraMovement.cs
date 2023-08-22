using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform camara;
    public float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        camara = transform.Find("Main Camera");
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Mouse X");
        float ver = Input.GetAxis("Mouse Y");
        if (hor != 0) {
            transform.Rotate(Vector3.up * hor * speed);
        }

        if (ver != 0)
        {
            //camara.Rotate(Vector3.left * ver * speed);
            float angle = (camara.localEulerAngles.x - ver * speed + 360) % 360;
            if (angle > 180) {
                angle -= 360;
            }
            angle = Mathf.Clamp(angle, -90, 90);
            camara.localEulerAngles = Vector3.right * angle; 
        }
    }
}
