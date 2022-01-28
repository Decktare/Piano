using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickS3 : MonoBehaviour
{
    public MainS3 main;
    public bool oneB;
    public bool twoB;
    public bool threeB;
    public bool fourB;

    

    public void OnClickOne()
    {
        if (oneB == main.oneAnswer)
        {
            TrueChoice();
        }
    }

    public void OnClickTwo()
    {
        if (twoB == main.twoAnswer)
        {
            TrueChoice();
        }
    }

    public void OnClickThree()
    {
        if (threeB == main.threeAnswer)
        {
            TrueChoice();
        }
    }

    public void OnClickFour()
    {
        if(fourB == main.fourAnswer)
        {
            TrueChoice();
        }
    }

    void TrueChoice()
    {
        main.questionCount++;
        main.score++;
        ChangeQuestion();
    }



    void ChangeQuestion()
    {
        switch (main.questionCount)
        {
            case 1:
                main.oneAnswer = false;
                main.twoAnswer = false;
                main.threeAnswer = false;
                main.fourAnswer = true;
                main.question.text = "Серега пидор?";
                main.buttonOne.text = "Нет";
                main.buttonTwo.text = "Нет";
                main.buttonThree.text = "Нет";
                main.buttonFour.text = "Да";
                break;
            case 2:
                main.oneAnswer = true;
                main.twoAnswer = false;
                main.threeAnswer = false;
                main.fourAnswer = false;
                main.question.text = "Серега пидор?";
                main.buttonOne.text = "Да";
                main.buttonTwo.text = "Нет";
                main.buttonThree.text = "Нет";
                main.buttonFour.text = "Нет";
                break;
            case 3:
                main.oneAnswer = false;
                main.twoAnswer = true;
                main.threeAnswer = false;
                main.fourAnswer = false;
                main.question.text = "Вопросы кончились?";
                main.buttonOne.text = "Нет";
                main.buttonTwo.text = "Да";
                main.buttonThree.text = "Нет";
                main.buttonFour.text = "Нет";
                break;
            default:
                main.oneAnswer = false;
                main.twoAnswer = false;
                main.threeAnswer = false;
                main.fourAnswer = false;
                main.question.text = "Вопросы кончились!";
                main.buttonOne.text = "-";
                main.buttonTwo.text = "-";
                main.buttonThree.text = "-";
                main.buttonFour.text = "-";
                break;
        }
    }
}
