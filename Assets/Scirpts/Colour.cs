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


        float GyroY = GetComponent<GyroData>().GetGyroY();

        GyroY = Mathf.Abs(GyroY);

        GyroY = GyroY % 1;


        //renderer.color = Color.HSVToRGB(Gyromums % 1, 1, 1);
        renderer.color = new Color(0.25f, GyroX, GyroY, 0.9f);
    }


}
