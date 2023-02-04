using UnityEngine;
using System.Collections;

public class RandomActiveButton : MonoBehaviour
{
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
}


/*using UnityEngine;
using System.Collections;

public class RandomActiveButton : MonoBehaviour
{
    public float appearInterval = 2f;
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
    }
}*/