using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colour : MonoBehaviour
{

    SpriteRenderer renderer;
    int v;
    int t;



    private void OnJointBreak(float breakForce)
    {
        
    }
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        //renderer.color = Color.HSVToRGB(0.2f, 1, 1);
        renderer.color = new Color(0, 255, 187, 1);


    }

    void Update()
    {

       float GyroX = GetComponent<GyroData>().GetGyroX();

        GyroX = Mathf.Abs(GyroX);

        GyroX = GyroX % 1;

        //int v = (int)GyroX;
        


        //byte [] GyroXOut = BitConverter.GetBytes(GyroX);

        //GyroX = (byte)(GyroX);

        float GyroY = GetComponent<GyroData>().GetGyroY();

        GyroY = Mathf.Abs(GyroY);

        GyroY = GyroY % 1;

       // int t = (int)GyroY;

        // byte[] GyroYOut = BitConverter.GetBytes(GyroY);

        //GyroY = (byte)(GyroY);

        // float vIn = 0.0f;
        //byte[] vOut = BitConverter.GetBytes(vIn);


        //renderer.color = Color.HSVToRGB(Gyromums % 1, 1, 1);
        renderer.color = new Color(0.3f, GyroX, GyroY, 0.7f);




    }


}
