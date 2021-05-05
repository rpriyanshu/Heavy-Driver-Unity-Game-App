using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForTimeScript : MonoBehaviour
{
   
    void Start()
    {
        StartCoroutine(ActivationRoutine());
    }

    IEnumerator ActivationRoutine()
 {
        yield return new WaitForSeconds(10);
        Debug.Log("Wait is Over");
    }
}
