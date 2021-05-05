using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UiManager : MonoBehaviour
{
    
    public void restartlevelBtn()
    {
        Time.timeScale = 1;
        TaxiScript.f = 0;
        SceneManager.LoadScene(1);
    }
    
    public void homeBtn()
    {
        SceneManager.LoadScene(0);
    }

    public void nextlevelBtn()
    {
        SceneManager.LoadScene(2);
    }
    public void playBtn()
    {
        

        SceneManager.LoadScene(1);
    }



    public void level2Btn()
    {
       
       
        SceneManager.LoadScene(2);
    }
    public void level3Btn()
    {
      
       
        SceneManager.LoadScene(3);
    }
}
