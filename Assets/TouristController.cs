using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouristController : MonoBehaviour
{
    public float Health
    {
        set
        {
            health = value;
            if (health <= 0)
            {
                Defeated();
            }
        }
        get
        {
            return health;
        }
    }

    public float health = 1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Defeated()
    {
        Destroy(gameObject);
    }
}
