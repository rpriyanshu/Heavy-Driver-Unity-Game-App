using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour
{
    public static AudioClip crash;
    public static AudioClip normal;
    static AudioSource audiosrc;

    void Start()
    {
       
        crash= Resources.Load<AudioClip>("crash");
        normal = Resources.Load<AudioClip>("normal");
        audiosrc = GetComponent<AudioSource>();
    }


    

    public static void playSound(string clip)
    {
        switch (clip)
        {
          
            case "crash":
                audiosrc.PlayOneShot(crash);
                break;
            case "normal":
                audiosrc.PlayOneShot(normal);
                break;
            case "mute":
                audiosrc.Stop();
                break;
        }
    }
}
