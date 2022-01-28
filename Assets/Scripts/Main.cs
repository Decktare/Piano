using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{    
    public GameObject _notes;
    public Sprite[] notes = new Sprite[7];
    public int insp;
    public int score = 0;
    public int mistakes = 0;
    public Text scoreText;
    public Text mistakesText;

    public bool noteDo = true;
    public bool noteRe = false;
    public bool noteMi = false;
    public bool noteFa = false;
    public bool noteSol = false;
    public bool noteLa = false;
    public bool noteSi = false;   
    
    void Update()
    {
        scoreText.text = "Очки: " + score;
        mistakesText.text = "Ошибки: " + mistakes;
    }
}
