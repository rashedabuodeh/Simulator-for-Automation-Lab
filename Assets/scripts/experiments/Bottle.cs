using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour
{
    public GameObject Bottle1;

    public float maximumMovment = 0f;
    public float minimumMovement = 0.3f;

    public float movementSpeed = 35f;

    bool playerIsHere;
    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
        Bottle1.transform.Translate(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {

        //   if( GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[19] ) // SENSOR2: P19 =1
        //  if (movingDoor.transform.position.x > maximumOpening2)
        { // remove if statement************

            //       
        }

        {// p18 motor right ouptut value

            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[18]) // conveyor right p18
            {
                Bottle1.transform.Translate(0f, 0f, movementSpeed * Time.deltaTime);
            }



            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[19]) //conveyor belt right p19
            {
                Bottle1.transform.Translate(0f,0f, -movementSpeed * Time.deltaTime);
            }

        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Sensor2")
        {
            playerIsHere = true;

        }
        if (col.gameObject.tag == "Sensor1")
        {
            playerIsHere = false;

        }
        //    if (col.gameObject.tag == "Sensor1")    check sensor 1 script
        //    {
        //       playerIsHere = true;
        //   }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Sensor2")
        {
            playerIsHere = false;

            if (col.gameObject.tag == "Sensor1")
            {
                playerIsHere = true;
            }
        }
    }


}
