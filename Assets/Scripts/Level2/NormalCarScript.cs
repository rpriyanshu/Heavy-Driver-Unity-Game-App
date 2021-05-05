using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalCarScript : MonoBehaviour
{
    public static int fn = 0;
    void Update()
    {
        if (fn == 1)
            transform.position = new Vector2(transform.position.x, transform.position.y + 0.08f);
    }
    public static void normal()
    {
        fn = 1;
    }
}
