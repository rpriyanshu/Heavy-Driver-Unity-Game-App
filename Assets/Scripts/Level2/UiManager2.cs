using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UiManager2 : MonoBehaviour
{
    public void restartlevelBtn()
    {
        TaxiScript.f = 0;
        NormalCarScript.fn = 0;
        PolceCarScript.fp = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }

    public void homeBtn()
    {
        SceneManager.LoadScene(0);
    }

    public void nextlevelBtn()
    {
        SceneManager.LoadScene(3);
    }

}
