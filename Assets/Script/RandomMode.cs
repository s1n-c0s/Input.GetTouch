using UnityEngine;

public class RandomMode : MonoBehaviour
{
    public ModeManager modeManager;

    public void ChangeModeRandomly()
    {
        int newModeIndex = Random.Range(1, modeManager.gameModeList.Count);
        modeManager.SetMode(newModeIndex);
    }
}
