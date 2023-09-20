using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text paleta1scoreText;
    [SerializeField] private TMP_Text paleta2scoreText;

    [SerializeField] private Transform paleta1transform;
    [SerializeField] private Transform paleta2transform;
    [SerializeField] private Transform bolatransform;

    private int paleta1score;
    private int paleta2score;


    private static GameManager instance;

    public static GameManager Instance 
    {
        get {
            if(instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;

        }
    }

    public void paleta1scored()
    {
        paleta1score++;
        paleta1scoreText.text = paleta1score.ToString();


    }

    public void paleta2scored()
    {
        paleta2score++;
        paleta2scoreText.text = paleta2score.ToString();


    }

    public void restart () 
    {
        paleta1transform.position = new Vector2(paleta1transform.position.x, 0);
        paleta2transform.position = new Vector2(paleta2transform.position.x, 0);
        bolatransform.position = new Vector2(0, 0); 

    }





}
