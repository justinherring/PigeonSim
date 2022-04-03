using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        IInventory inventory = GameObject.FindWithTag("Player").GetComponent<IInventory>();
        scoreText.text = "Score: " + inventory.numBread;
    }
}
