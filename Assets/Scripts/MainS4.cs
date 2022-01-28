using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;


public class MainS4 : MonoBehaviour
{

    public bool checkTimeOne;
    public bool checkTimeTwo;
    public bool checkTimeThree;
    public bool checkTimeFour;
    public bool checkTimeFive;
    public bool checkTimeSix;

    public Text buttonTextIndicator;

    public int checkClickCount = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnClickStart()
    {
        StartCoroutine(CheckTime());
    }

    IEnumerator CheckTime()
    {
        checkTimeOne = true;
        yield return new WaitForSeconds(1);
        checkTimeOne = false;
        yield return new WaitForSeconds(4);
        checkTimeTwo = true;
        yield return new WaitForSeconds(4);
        checkTimeTwo = false;
        checkTimeThree = true;
        yield return new WaitForSeconds(1);
        checkTimeThree = false;
    }

    public void OnClick()
    {
        switch (checkClickCount)
        {
            case 1: 
                if(checkTimeOne)
                {
                    buttonTextIndicator.text = "Своевременное нажатие 1"; checkClickCount++; break;
                }
                else
                {
                    buttonTextIndicator.text = "Не своевременное нажатие 1"; break;
                }
            case 2:
                if (checkTimeTwo)
                {
                    buttonTextIndicator.text = "Своевременное нажатие 1"; checkClickCount++; break;
                }
                else
                {
                    buttonTextIndicator.text = "Не своевременное нажатие 1"; break;
                }
            case 3:
                if (checkTimeThree)
                {
                    buttonTextIndicator.text = "Своевременное нажатие 1"; checkClickCount++; break;
                }
                else
                {
                    buttonTextIndicator.text = "Не своевременное нажатие 1"; break;
                }
            case 4:
                if (checkTimeFour)
                {
                    buttonTextIndicator.text = "Своевременное нажатие 1"; checkClickCount++; break;
                }
                else
                {
                    buttonTextIndicator.text = "Не своевременное нажатие 1"; break;
                }
            case 5:
                if (checkTimeFive)
                {
                    buttonTextIndicator.text = "Своевременное нажатие 1"; checkClickCount++; break;
                }
                else
                {
                    buttonTextIndicator.text = "Не своевременное нажатие 1"; break;
                }
            case 6:
                if (checkTimeSix)
                {
                    buttonTextIndicator.text = "Своевременное нажатие 1"; checkClickCount++; break;
                }
                else
                {
                    buttonTextIndicator.text = "Не своевременное нажатие 1"; break;
                }
            default: break;
        }
    }
}
