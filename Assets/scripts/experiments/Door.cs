using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject movingDoor;

    public float maximumOpening2 = 0f;
    public float maximumClosing2 = 0.3f;

    public float movementSpeed = 35f;

    bool playerIsHere;
    public PLC plc;
    public ChangInputValue_onClick onclick;
    //public bool Input1 = GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[18];

    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
        movingDoor.transform.Translate(0f, 0f, 0f);
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

            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[18])
            {
                movingDoor.transform.Translate(movementSpeed * Time.deltaTime, 0f, 0f);
            }



            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[19]) //19
            {
                movingDoor.transform.Translate(-movementSpeed * Time.deltaTime, 0f, 0f);
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
