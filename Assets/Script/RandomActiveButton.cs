using UnityEngine;
using System.Collections;

public class RandomActiveButton : MonoBehaviour
{
    /*   
       public GameObject[] buttons;

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



       /*public float appearInterval = 10f;
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

   */




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


    public GameObject button1;
    public GameObject button2;
    public float appearInterval = 2f;
    public float disappearInterval = 2f;

    void Start()
    {
        button1.SetActive(true);
        button2.SetActive(false);
        Invoke("SwitchButtons", appearInterval);
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
    }
}

