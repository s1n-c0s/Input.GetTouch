using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ModeManager : MonoBehaviour
{
    public int currentModeIndex;
    public GameObject[] gameModeList;
    public float modeDuration = 5.0f; // time in seconds for each mode
    public float modeDouble = 1f;
    private int previousModeIndex;
    private Coroutine modeCoroutine;

    private void Start()
    {
        SetMode(currentModeIndex);
    }

    public void SetMode(int modeIndex)
    {
        if (modeIndex >= 0 && modeIndex < gameModeList.Length && modeIndex != currentModeIndex)
        {
            previousModeIndex = currentModeIndex;
            currentModeIndex = modeIndex;
            ActivateMode(currentModeIndex);
            if (modeCoroutine != null) StopCoroutine(modeCoroutine);
            if (currentModeIndex is 2 or 3)
            {
                modeCoroutine = StartCoroutine(ChangeModeAfterDelay(previousModeIndex, modeDouble));
            }
            else
            {
                modeCoroutine = StartCoroutine(ChangeModeAfterDelay(previousModeIndex, modeDuration));
            }
        }
    }

    private void ActivateMode(int modeIndex)
    {
        for (int i = 0; i < gameModeList.Length; i++)
        {
            if (i == modeIndex)
            {
                gameModeList[i].SetActive(true);
            }
            else
            {
                gameModeList[i].SetActive(false);
            }
        }
    }

    private IEnumerator ChangeModeAfterDelay(int previousModeIndex, float delay)
    {
        yield return new WaitForSeconds(delay);
        SetMode(0);
        modeCoroutine = null;
    }
}


/*public class ModeManager : MonoBehaviour
{
    public List<GameObject> gameModeList;
    public int currentModeIndex;

    private void Start()
    {
        // Disable all game modes at the beginning
        foreach (var gameMode in gameModeList)
        {
            gameMode.SetActive(false);
        }

        // Enable the first game mode
        if (gameModeList.Count > 0)
        {
            currentModeIndex = 0;
            gameModeList[currentModeIndex].SetActive(true);
        }
    }

    public void SetMode(int modeIndex)
    {
        if (modeIndex < 0 || modeIndex >= gameModeList.Count)
        {
            Debug.LogError("Invalid mode index: " + modeIndex);
            return;
        }

        // Disable the current mode
        gameModeList[currentModeIndex].SetActive(false);

        // Enable the new mode
        currentModeIndex = modeIndex;
        gameModeList[currentModeIndex].SetActive(true);
    }
}*/
