using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float multiplier = 3f;
    public float duration = 2.5f;

    public GameObject pickupEffect;

    private bool isPickedUp = false;

    void OnMouseDown()
    {
        if (!isPickedUp)
        {
            StartCoroutine(Pickup());
        }
    }

    IEnumerator Pickup()
    {
        isPickedUp = true;
        Instantiate(pickupEffect, transform.position, transform.rotation);
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        while (duration > 0f)
        {
            yield return null;
            duration -= Time.deltaTime;
        }

        Destroy(gameObject);
    }
}
