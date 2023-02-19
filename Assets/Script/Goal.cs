/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        PlayerTouch();
    }

    void PlayerTouch()
     {
        Debug.Log("Win");
        Destroy(gameObject);
     }
}
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public GameObject linegoal;
    public Text winText;

    // Start is called before the first frame update
    void Start()
    {
        winText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player1"))
        {
            PlayerTouch(1);
        }
        else
        {
            PlayerTouch(2);
        }

    }

    private void PlayerTouch(int PlayerNum)
    {
        winText.gameObject.SetActive(true);
        winText.text = "Player"+PlayerNum+" Win!";
        Destroy(linegoal);
    }
}
