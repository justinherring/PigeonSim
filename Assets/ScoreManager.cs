using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;

    public static ScoreManager singleton = null;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (singleton == null)
        {
            singleton = this;
        }
    }
}
