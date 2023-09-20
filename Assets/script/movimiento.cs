using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    [SerializeField] private bool paleta1;
    [SerializeField] private bool paleta2;
    private float limite = 3.75f;

    void Update()
    {
        float movement = 0f; // Inicializamos movement con un valor predeterminado

        if (paleta1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        if (paleta2) 
        {
            movement = Input.GetAxisRaw("Vertical2");
        }

        transform.position += new Vector3(0, movement * speed * Time.deltaTime, 0);


        Vector2 paletaposicion = transform.position;
        paletaposicion.y = Mathf.Clamp(paletaposicion.y + movement * speed * Time.deltaTime, -limite, limite);
        transform.position = paletaposicion;
    }
}
