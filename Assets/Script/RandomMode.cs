using UnityEngine;

public class RandomMode : MonoBehaviour
{
    public ModeManager modeManager;
    public int IsPlayed = 1;
    public int newModeIndex;

    public void ChangeModeRandomly()
    {
        newModeIndex = Random.Range(1, modeManager.gameModeList.Length);
        if (IsPlayed < 3)
        {
            if (newModeIndex is 2 or 3)
            {
                IsPlayed++;
                modeManager.SetMode(newModeIndex);
            }
            else
            {
                modeManager.SetMode(newModeIndex);
            }
        }
        else
        {
            modeManager.SetMode(1);
            /*ChangeModeRandomly();*/
        }
    }
}
