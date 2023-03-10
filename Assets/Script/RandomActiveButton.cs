using UnityEngine;

using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine.UI;

public class RandomActiveButton : MonoBehaviour
{
    public List<GameObject> mode = new List<GameObject>();
    public int MaxTime, MinTime, BackMinT, BackMaxT;
    private int numToSwap, numToTurnBack;

    public float normalForm , swapForm;

    void Start() //come back some day/ min-max
    {

        numToSwap = UnityEngine.Random.Range(MinTime, MaxTime);
        Debug.Log(numToSwap);

        numToTurnBack = UnityEngine.Random.Range(BackMinT, BackMaxT);
        Debug.Log(numToTurnBack);

        mode[0].SetActive(true);
        //normalBT.SetActive(true);
        
        mode[1].SetActive(false);
        //SwapBT.SetActive(false);
        Invoke("SwitchButtons", normalForm = numToSwap);
        Debug.Log("Countdown before swap: " + numToSwap + " seconds");
    }

    void SwitchButtons()
    {
        mode[0].SetActive(false);
        mode[1].SetActive(true);

        //normalBT.SetActive(false);
        //SwapBT.SetActive(true);
        Invoke("TurnBack", swapForm = numToTurnBack);
        Debug.Log("Countdown after swap: " + numToTurnBack + " seconds");
    }

    void TurnBack()
    {
        mode[0].SetActive(true);
        mode[1].SetActive(false);
        /*normalBT.SetActive(true);
        SwapBT.SetActive(false);*/
    }   
}
    









/*public GameObject[] buttons;

    void Start()
    {
        RandomSwap();
    }

    public void RandomSwap()
    {
        int randomIndex = Random.Range(0, buttons.Length);
        for (int i = 0; i < buttons.Length; i++)
        {
            if (i == randomIndex)
                buttons[i].SetActive(true);
            else
                buttons[i].SetActive(false);
        }
    }



    *//*public float appearInterval = 10f;
    public float disappearInterval = 2f;

    void Start()
    {
        Invoke("Appear", Random.Range(0, appearInterval));
    }

    void Appear()
    {
        gameObject.SetActive(true);
        Invoke("Disappear", disappearInterval);
    }

    void Disappear()
    {
        gameObject.SetActive(false);
        Invoke("Appear", Random.Range(0, appearInterval));






/*public GameObject button1;
public GameObject button2;

void Start()
{
 int randomIndex = Random.Range(0, 2);
 button1.SetActive(randomIndex == 0);
 button2.SetActive(randomIndex == 1);*/


    /*public float appearInterval = 10f; // ?????????
    public float disappearInterval = 2f;

    public GameObject button1;
    public GameObject button2;

    void Start()
    {
        button1.SetActive(true);
        button2.SetActive(false);
        Invoke("SwitchButtons", Random.Range(0, appearInterval));
    }

    void SwitchButtons()
    {
        button1.SetActive(false);
        button2.SetActive(true);
        Invoke("TurnBack", disappearInterval);
    }

    void TurnBack()
    {
        button1.SetActive(true);
        button2.SetActive(false);
    }*/

    /*void Start()
    {
        int randomNumber = UnityEngine.Random.Range(1, 101);
        Debug.Log(randomNumber);
    }*/
