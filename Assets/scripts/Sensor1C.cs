using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor1C : MonoBehaviour
{
    public GameObject Bottle1;

    public float maximumOpening = 0.271f;
    public float maximumClosing = 0.0015f;

    public float movementSpeed = 25f;
    public int sensor1address = 2;

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
            //  if (movingDoor.transform.position.x < maximumOpening)
            //  {
            //  movingDoor.transform.Translate(30 * Time.deltaTime, 0f, 0f);
            GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[sensor1address] = true; // SENSOR2: P19 =1 // true

            //  movingDoor.transform.Translate(0f, 0f, 0f);
            //  }

            // HINT: change the value of sensor to ONE (fully closed)
        }
        else
        {
            GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[sensor1address] = false; // SENSOR2: P19 =1

            //if (movingDoor.transform.position.x > maximumClosing)
            // {
            //    movingDoor.transform.Translate(-movementSpeed * Time.deltaTime, 0f, 0f);
            // }


            // HINT: change the value of sensor to ZERO (not fully closed)
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
