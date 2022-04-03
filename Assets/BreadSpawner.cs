using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadSpawner : MonoBehaviour
{
    public GameObject Object;
    public float startTimeBtwSpawn = 10;
    float timebtwspawn = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timebtwspawn <= 0)
        {
            Instantiate(Object, transform.position, Quaternion.identity);
            timebtwspawn = startTimeBtwSpawn;
        }
        else
        {
            timebtwspawn -= Time.deltaTime;
        }
    }
}
