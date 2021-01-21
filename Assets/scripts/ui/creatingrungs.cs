using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatingrungs : MonoBehaviour


{
    public GameObject rung = null;

    public void rungs()

    {

        GameObject.Instantiate(rung, GameObject.FindGameObjectWithTag("RungContainer").transform);
    }
}



