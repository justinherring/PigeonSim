using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadPickup : MonoBehaviour
{
    public int numSlices = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            IInventory inventory = other.GetComponent<IInventory>();

            if (inventory != null)
            {
                inventory.numBread += numSlices;
                gameObject.SetActive(false);
            }
        }
    }
}
