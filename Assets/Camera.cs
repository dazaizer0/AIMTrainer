using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    public bool isControlling = false;

    public float horizontalSensivity = 2.0f;
    public float verticalSensivity = 2.0f;
    float xWanted, xCurrent, yDelta;
    Transform rol;


    void Start() {rol = GetComponent<Transform>();}

    void Update()
    {

        if(Input.GetMouseButton(1))
        {

            isControlling = true;
            isControllingChanger();
        }
        else
        {

            isControlling = false;
            isControllingChanger();
        }
    }

    void isControllingChanger()
    {

        if(isControlling)
        {

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            yDelta = horizontalSensivity * Input.GetAxis("Mouse X");
            xWanted = (xWanted <= 90) ? ((xWanted >= -90) ? xWanted + verticalSensivity * Input.GetAxis("Mouse Y") : -90) : 90;

            transform.Rotate(xCurrent - xWanted, 0, 0, Space.Self);
            xCurrent = xWanted;

            transform.Rotate(0, yDelta, 0, Space.World);
        }
        else
        {

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
