using UnityEngine;
using UnityEngine.UI;

public class MoveForwardOnButtonPress1 : MonoBehaviour
{
    public float speed = 10.0f;
    public Button button;

    void Start()
    {
        button.onClick.AddListener(Move);
    }

    void Move()
    {
        int randomEvent = Random.Range(0, 2);
        if (randomEvent == 0)
        {
            SwapPlayers();
        }
        else
        {
            Wander();
        }
    }

    void SwapPlayers()
    {
        // Add code to swap players here
    }

    void Wander()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
