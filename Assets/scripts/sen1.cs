using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sen1 : MonoBehaviour
{

    public GameObject movingDoor;

    public float maximumOpening2 = 0f;
    public float maximumClosing2 = 0.3f;

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
          //  if (movingDoor.transform.position.x > maximumOpening2)
            {

                movingDoor.transform.Translate(0f, 0f, 0f);
            }
        }
        else 
        {
            movingDoor.transform.Translate(-movementSpeed * Time.deltaTime, 0f, 0f);
        }
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Sensor2")
        {
            playerIsHere = true;
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

        //    if (col.gameObject.tag == "Sensor1")
          //  {
         //       playerIsHere = true;
          //  }
        }
    }




}