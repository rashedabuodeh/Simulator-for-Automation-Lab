using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarageOnOff : MonoBehaviour
{

    public GameObject Light1;
    public GameObject Light2;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[16]) // 
        {
            Light1.gameObject.SetActive(true);
        }

        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[17]) // 
        {
            Light2.gameObject.SetActive(true);
        }

        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[16]) // 
        {
            Light1.gameObject.SetActive(false);
        }

        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[17]) // 
        {
            Light2.gameObject.SetActive(false);
        }
    }
    void SensorUpDate()
    {

        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[16]) // 
        {
            Light1.gameObject.SetActive(true);
        }

        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[17]) // 
        {
            Light2.gameObject.SetActive(true);
        }

        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[16]) // 
        {
            Light1.gameObject.SetActive(false);
        }

        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[17]) // 
        {
            Light2.gameObject.SetActive(false);
        }
    }
}
