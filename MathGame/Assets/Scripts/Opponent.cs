using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent : MonoBehaviour
{
    public button btn;
    public WonLost wl;
    public int a;
    public int speed;
    Rigidbody2D rbop;
    public float curtimeop = 0;
    public float maxtime = 1;
    public int minval;
    public int maxval;
    void Start()
    {
        speed = 0;
        rbop = GetComponent<Rigidbody2D>();
        a = 0;
        if(btn.startpressed == false)
        {
            speed = 0;
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Finish"))
        {
            wl.Canvas.SetActive(true);
            Time.timeScale = 0;
        }
    }
    void Update()
    {

        if (btn.startpressed == false)
        {
            speed = 0;
            a = 0;
        }

        if(btn.startpressed == true)
        {
            speed = 3;
        }
        
        if (btn.correctans == true)
        {
            speed = 2;
            a = Random.Range(minval, maxval);
            rbop.velocity = new Vector2(speed + a, 0);
            curtimeop = 0;
        }

        if (btn.correctans == false)
        {
            
            //a = Random.Range(minval, maxval);
            rbop.velocity = new Vector2(speed + a, 0);
            curtimeop = 0;
        }
        curtimeop += Time.deltaTime;


    }
}
