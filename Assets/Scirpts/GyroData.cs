using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class GyroData : MonoBehaviour
{

    private bool gyroEnabled;
    //float Gyromums;
    float GyroX;
    float GyroY;
    //public Text Data;
   // Vector2 gyrovector;


    private void Start()
    {
        gyroEnabled = EnableGyro();
    }

    private bool EnableGyro()
    {

        InputSystem.EnableDevice(AttitudeSensor.current);

        return true;

    }

    private void Update()
    {

        //Debug.Log(AttitudeSensor.current.attitude.ReadValue());
        Quaternion value = AttitudeSensor.current.attitude.ReadValue();
        float x = value.x;
        float y = value.y;

        //gyrovector = new Vector2(x, y);

        //Gyromums = (x + y) * 4;

        GyroX = x;
        GyroY = y;

    }

    /*public float GetGyromums()

    {
        return Gyromums;
    }*/

    public float GetGyroX()

    {
        return GyroX;
    }

    public float GetGyroY()

    {

        return GyroY;
    }

}
