using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
    public Transform targetPosition;
    public Transform offset;

   
    void Update()
    {
        
            Vector3 newPosition = targetPosition.position - offset.position;
            newPosition.x = 0;
            newPosition.z = -10;
            transform.position = newPosition;
        
       
       
    }
}
