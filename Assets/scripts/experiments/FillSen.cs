using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillSen : MonoBehaviour
{
    // Start is called before the first frame update


    public GameObject movingDoor;

    public float maximumOpening = 0.271f;
    public float maximumClosing = 0.0015f;

    public float movementSpeed = 25f;

    public float timer = 1;
    bool playerIsHere;

    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsHere)
        {
            GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[4] = true;
           
        }
        else
        {
            GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[4] = false;
            timer = 1;

        }

        if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[20])
        {
            timer -= Time.deltaTime;
            if(timer<=0)
            {
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[5] = true;
                timer = 1;
            }
            else
            {
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[5] = false;
            }
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerIsHere = true;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            playerIsHere = false;
        }
    }
}
