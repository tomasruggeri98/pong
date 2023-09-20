using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    
    private Rigidbody2D rb;
    [SerializeField] private float inicialvelocidad = 4f;
    [SerializeField] private float velocidadmultiplayer = 1.1f;
     
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        launch();
    }


    private void launch()
    {
        float xvelocidad = Random.Range(0, 2) == 0 ? 1 : -1;
        float yvelocidad = Random.Range(0, 2) == 0 ? 1 : -1;
        rb.velocity = new Vector2(xvelocidad, yvelocidad) * inicialvelocidad;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("paleta")) 
        {
            rb.velocity *= velocidadmultiplayer;

        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("gol1")) 
        {
            GameManager.Instance.paleta2scored();
            GameManager.Instance.restart();
            launch();
        }
        else 
        {
            GameManager.Instance.paleta1scored();
            GameManager.Instance.restart();
            launch();
        }
    }

}
