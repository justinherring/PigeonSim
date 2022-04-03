using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    public GameObject player;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        IInventory inventory = player.GetComponent<IInventory>();
        scoreText.text = "Score: " + inventory.numBread;
    }
}
