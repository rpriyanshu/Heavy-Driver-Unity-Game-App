using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class FinishLineScripts : MonoBehaviour
{
    //Fade time in seconds
    public static float fadeOutTime;
    public static Text text;
    
   public static IEnumerator FadeOutRoutine()
    {
        
        Color originalColor = text.color;
        for (float t = 0.01f; t < fadeOutTime; t += Time.deltaTime)
        {
            text.color = Color.Lerp(originalColor, Color.clear, Mathf.Min(1, t / fadeOutTime));
            yield return null;
        }
    }
}