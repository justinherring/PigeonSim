using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Object;
    public GameObject player;
    public float startTimeBtwSpawn = 10;
    float timebtwspawn = 0;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timebtwspawn <= 0)
        {
            GameObject enemy = Instantiate(Object, transform.position, Quaternion.identity);
            EnemyController enemyController = enemy.GetComponent<EnemyController>();
            enemyController.playerObj = player;
            timebtwspawn = startTimeBtwSpawn;
        } 
        else
        {
            timebtwspawn -= Time.deltaTime;
        }
    }
}
