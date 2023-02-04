using UnityEngine;
using UnityEngine.UI;

public class RandomEventButton : MonoBehaviour
{
    public Button button;
    public GameObject player1;
    public GameObject player2;

    private void Start()
    {
        button.onClick.AddListener(RandomEvent);
    }

    void RandomEvent()
    {
        int randomNumber = Random.Range(1, 2);
        if (randomNumber == 1)
        {
            player1.SetActive(false);
            player2.SetActive(true);
            Debug.Log("Player switched to 2");
        }
        else
        {
            player1.SetActive(true);
            player2.SetActive(false);
            Debug.Log("Player switched to 1");
        }
    }
}