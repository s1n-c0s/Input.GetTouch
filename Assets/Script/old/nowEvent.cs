using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nowEvent : MonoBehaviour
{
    public List<GameObject> gameModeList;
    public int nowMode;
    public bool NormalMode, SwapMode, DoubleP1, DoubleP2;

    private void Start()
    {
        /*gameModeList = new List<GameObject>();*/
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
}
