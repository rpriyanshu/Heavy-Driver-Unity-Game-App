using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolceCarScript : MonoBehaviour
{

    public static int fp = 0;
    float p = 0;
    void Update()
    {
        if (fp == 1 && p < 40)
        {
            transform.position = new Vector2(transform.position.x + 0.05f, transform.position.y);
           
        }
        if (fp == 1)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.07f);
            p++;
        }
        if (fp == 1 && p > 100 && p < 140)
        {
            transform.position = new Vector2(transform.position.x - 0.05f, transform.position.y);
           
        }


        if (fp == 1 && p > 200 && p<240)
        {
            transform.position = new Vector2(transform.position.x + 0.05f, transform.position.y);

        }

        if (fp == 1 && p > 300 && p < 340)
        {
            transform.position = new Vector2(transform.position.x - 0.05f, transform.position.y);

        }

    }
    public static void police()
    {
        fp = 1;
    }

}
