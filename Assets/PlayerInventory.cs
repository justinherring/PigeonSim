using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour, IInventory
{

    public int numBread { get => _numBread; set => _numBread = value; }

    private int _numBread = 0;

}
