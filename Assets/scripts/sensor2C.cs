using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sensor2C : MonoBehaviour
{

    public GameObject movingDoor;

    public float maximumOpening = 0.271f;
    public float maximumClosing = 0.0015f;

    public float movementSpeed = 25f;

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
            GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[3] = true;
            //  if (movingDoor.transform.position.x < maximumOpening)
            //  {
            //  movingDoor.transform.Translate(30 * Time.deltaTime, 0f, 0f);

            movingDoor.transform.Translate(0f, 0f, 0f);
            //  }

            // HINT: change the value of sensor to ONE (fully closed)
        }
        else
        {
            GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[3] = false;
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