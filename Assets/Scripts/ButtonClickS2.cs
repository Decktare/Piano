using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClickS2 : MonoBehaviour
{
    public MainS2 main;
    public bool nDo;
    public bool nRe;
    public bool nMi;
    public bool nFa;
    public bool nSol;
    public bool nLa;
    public bool nSi;
    private int check;
    public Animation Anim;

    public void OnClick()
    {
        switch (main.insp)
        {
            case 0:
                if (nDo == main.noteDo)
                {
                    TrueChoice(); break;
                }
                else
                {
                    Anim.Play("FalseClick");
                    main.mistakes++;
                    break;
                }
            case 1:
                if (nRe == main.noteRe)
                {
                    TrueChoice(); break;
                }
                else
                {
                    Anim.Play("FalseClick");
                    main.mistakes++;
                    break;
                }
                break;
            case 2:
                if (nMi == main.noteMi)
                {
                    TrueChoice(); break;
                }
                else
                {
                    Anim.Play("FalseClick");
                    main.mistakes++;
                    break;
                }
                break;
            case 3:
                if (nFa == main.noteFa)
                {
                    TrueChoice(); break;
                }
                else
                {
                    Anim.Play("FalseClick");
                    main.mistakes++;
                    break;
                }
                break;
            case 4:
                if (nSol == main.noteSol)
                {
                    TrueChoice(); break;
                }
                else
                {
                    Anim.Play("FalseClick");
                    main.mistakes++;
                    break;
                }
                break;
            case 5:
                if (nLa == main.noteLa)
                {
                    TrueChoice(); break;
                }
                else
                {
                    Anim.Play("FalseClick");
                    main.mistakes++;
                    break;
                }
                break;
            case 6:
                if (nSi == main.noteSi)
                {
                    TrueChoice(); break;
                }
                else
                {
                    Anim.Play("FalseClick");
                    main.mistakes++;
                    break;
                }
                break;
            default: break;
        }
    }

    void TrueChoice()
    {
        main.score++;

        do
        {
            check = Mathf.RoundToInt(UnityEngine.Random.Range(0f, 6f));
        } while (check == main.insp);

        main.insp = check;
        Anim.Play("TrueClick");
        main._notes.GetComponent<Image>().sprite = main.notes[main.insp];
        switch (main.insp)
        {
            case 0: main.noteDo = true; main.noteRe = false; main.noteMi = false; main.noteFa = false; main.noteSol = false; main.noteLa = false; main.noteSi = false; break;
            case 1: main.noteDo = false; main.noteRe = true; main.noteMi = false; main.noteFa = false; main.noteSol = false; main.noteLa = false; main.noteSi = false; break;
            case 2: main.noteDo = false; main.noteRe = false; main.noteMi = true; main.noteFa = false; main.noteSol = false; main.noteLa = false; main.noteSi = false; break;
            case 3: main.noteDo = false; main.noteRe = false; main.noteMi = false; main.noteFa = true; main.noteSol = false; main.noteLa = false; main.noteSi = false; break;
            case 4: main.noteDo = false; main.noteRe = false; main.noteMi = false; main.noteFa = false; main.noteSol = true; main.noteLa = false; main.noteSi = false; break;
            case 5: main.noteDo = false; main.noteRe = false; main.noteMi = false; main.noteFa = false; main.noteSol = false; main.noteLa = true; main.noteSi = false; break;
            case 6: main.noteDo = false; main.noteRe = false; main.noteMi = false; main.noteFa = false; main.noteSol = false; main.noteLa = false; main.noteSi = true; break;
            default: break;
        }
    }
}
