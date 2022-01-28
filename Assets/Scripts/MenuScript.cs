using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public Transform DoubleMenu;
    //public Transform Menu;
    private int inspector = 1;
    public bool flag1 = false;
    public bool flag2 = false;
    public float test;
    //public float test2;

    public void OnClickStart()
    {
        StartCoroutine(WaitTime(1));
    }
    public void OnClickExit()
    {
        Application.Quit();
    }

    public void OnClickMenu()
    {
        StartCoroutine(WaitTime(0));
    }

    public void OnClickSetup()
    {
        StartCoroutine(WaitTime(1));
    }

    public void OnClickSetOne()
    {
        StartCoroutine(WaitTime(2));
    }

    public void OnClickSetTwo()
    {
        StartCoroutine(WaitTime(3));
    }

    public void OnClickSwitch()
    {
        if (!flag1 && !flag2)
        {        
            switch (inspector)
            {
                case 1: flag1 = true; inspector = 2; break;

                case 2: flag2 = true; inspector = 1; break;
            }
        }
    }

    void Update()
    {
        test = DoubleMenu.position.x;
        //test2 = Menu.position.x;
        if (DoubleMenu.position.x > 0 && flag1)
        {
            DoubleMenu.position += new Vector3(Time.deltaTime * -8, 0, 0);
            //Menu.position += new Vector3(Time.deltaTime * -8, 0, 0);
            
        }
        if (DoubleMenu.position.x <= 0 && flag1)
        {
            DoubleMenu.position = new Vector3(0, 0, 0);
            //Menu.position = new Vector3((float)(double)-5.625, 0, 0);
            flag1 = false;
        }
        if (DoubleMenu.position.x < 5.625 && flag2)
        {
            DoubleMenu.position += new Vector3(Time.deltaTime * 8, 0, 0);
            //Menu.position += new Vector3(Time.deltaTime * 8, 0, 0);
            
        }
        if (DoubleMenu.position.x >= 5.625 && flag2)
        {
            DoubleMenu.position = new Vector3((float)(double)5.625, 0, 0);
            //Menu.position = new Vector3(0, 0, 0);
            flag2 = false;
        }
    }

    IEnumerator WaitTime(int sceneint)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneint);
    }
}
