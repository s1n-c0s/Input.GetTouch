using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedDown : MonoBehaviour
{
    public float multiplier2 = 3f;
    public float duration2 = 5f;
    //public GameObject pickupEffect2;

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player1"))
        {
            StartCoroutine(Pickup2(other));
        }
        else if (other.CompareTag("Player2"))
        {
            StartCoroutine(Pickup3(other));
        }
    }

    IEnumerator Pickup2(Collider player1)
    {
        //Instantiate(pickupEffect2, transform.position, transform.rotation);

        MoveForwardOnButtonPress PlayerMove = player1.GetComponent<MoveForwardOnButtonPress>();
        PlayerMove.speed /= multiplier2;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration2);

        PlayerMove.speed *= multiplier2;

        Destroy(gameObject);
        Debug.Log("Sht touch");
    }

    IEnumerator Pickup3(Collider player2)
    {
        //Instantiate(pickupEffect2, transform.position, transform.rotation);

        MoveForwardOnButtonPress PlayerMove = player2.GetComponent<MoveForwardOnButtonPress>();
        PlayerMove.speed /= multiplier2;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration2);

        PlayerMove.speed *= multiplier2;

        Destroy(gameObject);
        Debug.Log("Sht touch");
    }
}
