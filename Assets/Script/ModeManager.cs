using System.Collections.Generic;
using UnityEngine;

public class ModeManager : MonoBehaviour
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
}
