using UnityEngine;
using UnityEngine.UI;

public class MoveForwardOnButtonPress : MonoBehaviour
{
    public float speed = 10.0f;
    public Button button;

    void Start()
    {
        button.onClick.AddListener(Move);
    }

    void Move()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}
