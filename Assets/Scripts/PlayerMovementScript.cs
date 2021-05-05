using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovementScript : MonoBehaviour
{
    public static PlayerMovementScript Instance { set; get; }

    Rigidbody2D rb;
    float dirX;
    public float speed;
    float s= 0.06f;
    public float fadeOutTime;
    public Text text;
    public Text countDown;
    public Text level;
    public GameObject LevelCompletePanel;
    public GameObject lostPanel;
    public GameObject Tyre;
    
    public static float f = 6;
    
    void Start()
    {
        Instance = this;
        rb = GetComponent<Rigidbody2D>();
        transform.position = new Vector2(transform.position.x, -3.11f);
        Time.timeScale = 1;
       
    }

   
    void Update()
    {
        f -=Time.deltaTime;
        countDown.text = f.ToString();
        if (f < 1)
        {
            
            countDown.gameObject.SetActive(false);
            s = s + 0.00002f;

            dirX = Input.acceleration.x * 10f;
            transform.position = new Vector2(Mathf.Clamp(transform.position.x, -1.56f, 1.59f), transform.position.y + s);
            if (Input.anyKey)
            {
                SoundScript.playSound("normal");
                transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            else
            {
                SoundScript.playSound("mute");
            }
        }
       
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, 0f);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "start")
        {
            text.gameObject.SetActive(true);

            text.text = "START";
            StartCoroutine(FadeOutRoutine());
            Timer.l = 1;
        }

        if (collision.gameObject.tag == "Taxi")
        {
            TaxiScript.taxi();
        }
        if (collision.gameObject.tag == "Normal")
        {
            NormalCarScript.normal();
        }

        if (collision.gameObject.tag == "Police")
        {
            PolceCarScript.police();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "end")
        {
            speed = 0;
            s = 0.03f;
            level.gameObject.SetActive(false);
            LevelCompletePanel.SetActive(true);
            Time.timeScale = 0;
            TaxiScript.f = 0;
            NormalCarScript.fn = 0;
            Tyre.SetActive(false);
            Timer.l = 0;
            f = 6;
            
        }

        if (collision.gameObject.tag == "Taxi")
        {
            TaxiScript.f = 0;
        }

        if (collision.gameObject.tag == "Normal")
        {
            NormalCarScript.fn = 0;
        }

        if (collision.gameObject.tag == "Police")
        {
            PolceCarScript.fp = 0;
        }
    }
    private IEnumerator FadeOutRoutine()
    {

        Color originalColor = text.color;
        for (float t = 0.01f; t < fadeOutTime; t += Time.deltaTime)
        {
            text.color = Color.Lerp(originalColor, Color.clear, Mathf.Min(1, t / fadeOutTime));
            yield return null;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        lostPanel.SetActive(true);
        Time.timeScale = 0;
        level.gameObject.SetActive(false);
        Tyre.SetActive(false);
        Handheld.Vibrate();
        Timer.l = 0;
        f = 6;
        SoundScript.playSound("crash");
        
    }





}