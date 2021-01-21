using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticDoor : MonoBehaviour
{

    public GameObject movingDoor;

    public float maximumOpening = 10f;
    public float maximumClosing = 0f;

    public float movementSpeed = 5f;

    bool DoorOpened;

    // Start is called before the first frame update
    void Start()
    {
        DoorOpened = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (DoorOpened)
        {
            GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[2] = true;
            //  if (movingDoor.transform.position.x < maximumOpening)
            // {
            //     movingDoor.transform.Translate(movementSpeed * Time.deltaTime, 0f, 0f);
            // }

            // HINT: change the value of sensor to ZERO (fully opened)
        }
        else
        {
            GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[2] = true;
            //    if (movingDoor.transform.position.x > maximumClosing)
            //  {
            //    movingDoor.transform.Translate(-movementSpeed * Time.deltaTime, 0f, 0f);
            // }

            // HINT: change the value of sensor to ONE, Door is not fully opened
        }


    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            DoorOpened = false;
        }
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            DoorOpened = true;
        }
    }
}