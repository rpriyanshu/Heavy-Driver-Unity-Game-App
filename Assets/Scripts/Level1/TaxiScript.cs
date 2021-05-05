using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaxiScript : MonoBehaviour
{
    
   public static int f = 0;
     void Update()
    {
        if (f == 1)
            transform.position =new  Vector2(transform.position.x, transform.position.y + 0.04f);
    }
    public static void taxi()
    {
        f = 1;   
    }


}
