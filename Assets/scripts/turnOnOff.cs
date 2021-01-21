using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOnOff : MonoBehaviour
{
    public GameObject Red;
    public GameObject Orng;
    public GameObject Green;
    public GameObject Red2;
    public GameObject Orng2;
    public GameObject Green2;

    public GameObject Red3;
    public GameObject Green3;
    public GameObject Red4;
    public GameObject Green4;

    // Start is called before the first frame update
    public void Start()
    {
        Red.gameObject.SetActive(false);
        Orng.gameObject.SetActive(false);
        Green.gameObject.SetActive(false);

        Red2.gameObject.SetActive(false);
        Orng2.gameObject.SetActive(false);
        Green2.gameObject.SetActive(false);

        Red3.gameObject.SetActive(false);
        Green3.gameObject.SetActive(false);

    }
    public void Update()
    {
        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[16]) // Red light 16 , orng 17 , green 18 
        {
            Red.gameObject.SetActive(true);
        }
        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[16])
        {
            Red.gameObject.SetActive(false);
        }
        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[17]) // Red light 16 , orng 17 , green 18 
        {
            Orng.gameObject.SetActive(true);
        }
        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[17])
        {
            Orng.gameObject.SetActive(false);
        }
        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[18]) // Red light 16 , orng 17 , green 18 
        {
            Green.gameObject.SetActive(true);
        }
        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[18])
        {
            Green.gameObject.SetActive(false);
        }

        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[19]) // Red light 16 , orng 17 , green 18 
        {
            Red2.gameObject.SetActive(true);
        }
        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[19])
        {
            Red2.gameObject.SetActive(false);
        }
        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[20]) // Red light 16 , orng 17 , green 18 
        {
            Orng2.gameObject.SetActive(true);
        }
        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[20])
        {
            Orng2.gameObject.SetActive(false);
        }
        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[21]) // Red light 16 , orng 17 , green 18 
        {
            Green2.gameObject.SetActive(true);
        }
        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[21])
        {
            Green2.gameObject.SetActive(false);
        }


        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[22]) // Red light 16 , orng 17 , green 18 
        {
            Green3.gameObject.SetActive(true);
        }
        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[22])
        {
            Green3.gameObject.SetActive(false);
        }

        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[23]) // Red light 16 , orng 17 , green 18 
        {
            Red3.gameObject.SetActive(true);
        }
        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[23])
        {
            Red3.gameObject.SetActive(false);
        }

        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[24]) // Red light 16 , orng 17 , green 18 
        {
            Red4.gameObject.SetActive(true);
        }
        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[24])
        {
            Red4.gameObject.SetActive(false);
        }

        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[25]) // Red light 16 , orng 17 , green 18 
        {
            Green4.gameObject.SetActive(true);
        }
        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[25])
        {
           Green4.gameObject.SetActive(false);
        }



    }

    public void TurnOn()
    {
        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[16]) // Red light 16 , orng 17 , green 18 
        {
            Red.gameObject.SetActive(true);
        }
        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[16])
        {
            Red.gameObject.SetActive(false);
        }
        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[17]) // Red light 16 , orng 17 , green 18 
        {
            Orng.gameObject.SetActive(true);
        }
        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[17])
        {
            Orng.gameObject.SetActive(false);
        }
        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[18]) // Red light 16 , orng 17 , green 18 
        {
            Green.gameObject.SetActive(true);
        }
        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[18])
        {
            Green.gameObject.SetActive(false);
        }

        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[19]) // Red light 16 , orng 17 , green 18 
        {
            Red2.gameObject.SetActive(true);
        }
        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[19])
        {
            Red2.gameObject.SetActive(false);
        }
        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[20]) // Red light 16 , orng 17 , green 18 
        {
            Orng2.gameObject.SetActive(true);
        }
        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[20])
        {
            Orng2.gameObject.SetActive(false);
        }
        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[21]) // Red light 16 , orng 17 , green 18 
        {
            Green2.gameObject.SetActive(true);
        }
        if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[21])
        {
            Green2.gameObject.SetActive(false);
        }



    }
    public void Pressed()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[0] = true;

    }
    public void released()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[0] = false;
    }
}
