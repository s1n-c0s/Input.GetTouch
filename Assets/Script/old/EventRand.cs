using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventRand : MonoBehaviour
{
    private List<GameObject> gameModeList;
    //[SerializeField]private GameObject[] mode;
    int nowMode;
    public bool NormalMode, SwapMode, DoubleP1, DoubleP2;

    public void SetGameObjectList(List<GameObject> list)
    {
        gameModeList = list;
    }


    private void Start()
    {
        
    }

    private void Update()
    {
       Onmode(nowMode);
    }

    public void Onmode(int nowMode)
    {
        switch (nowMode)
        {
            case 0:
                NormalMode = true;
                SwapMode = false;
                DoubleP1 = false;
                DoubleP2 = false;
                break;
            case 1:
                NormalMode = false;
                SwapMode = true;
                DoubleP1 = false;
                DoubleP2 = false;
                break;
            case 2:
                NormalMode = false;
                SwapMode = false;
                DoubleP1 = true;
                DoubleP2 = false;
                break;
            case 3:
                NormalMode = false;
                SwapMode = false;
                DoubleP1 = false;
                DoubleP2 = true;
                break;
            default:
                NormalMode = false;
                SwapMode = false;
                DoubleP1 = false;
                DoubleP2 = false;
                break;
        }
    }


    public void RandomMode()
    {
        int randomIndex = Random.Range(0, gameModeList.Count);
        for (int i = 0; i < gameModeList.Count; i++)
        {
            if (i == randomIndex)
            {
                nowMode = i;
                gameModeList[i].SetActive(true);
            }
            else
                gameModeList[i].SetActive(false);
        }
    }
}