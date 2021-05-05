using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public Text timer;
    public float timeRemaining;
    public GameObject lostPanel;
    public GameObject tyre;
    public static int l = 0;
    public Text level;
    private void Start()
    {
        tyre.SetActive(true);
        timer.text = "0:" + timeRemaining.ToString();
    }
    void Update()
    {
        if (l == 1)
        {
            timer.text = "0:" + timeRemaining.ToString();
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                tyre.SetActive(false);
                lostPanel.SetActive(true);
                Time.timeScale = 0;
                level.gameObject.SetActive(false);
                l = 0;
                PlayerMovementScript.f = 6;
                
            }
        }
    }
}
