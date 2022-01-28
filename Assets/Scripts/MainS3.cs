using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class MainS3 : MonoBehaviour
{
    public Text buttonOne;
    public Text buttonTwo;
    public Text buttonThree;
    public Text buttonFour;

    public Text question;

    public int score = 0;
    public int mistakes = 0;

    public int questionCount = 0;

    public bool oneAnswer;
    public bool twoAnswer;
    public bool threeAnswer;
    public bool fourAnswer;

    void Start()
    {
        oneAnswer = false;
        twoAnswer = false;
        threeAnswer = true;
        fourAnswer = false;
        question.text = "Серега пидор?";
        buttonOne.text = "Нет";
        buttonTwo.text = "Нет";
        buttonThree.text = "Да";
        buttonFour.text = "Нет";
    }

    void Update()
    {
        
    }  
    
}
