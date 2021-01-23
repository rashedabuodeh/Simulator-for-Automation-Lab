using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public PLC plc;
    // GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[1]=true ;

    bool Input2 = GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[2];

    // Start is called before the first frame update
    void Start()
    {
      //  plc.P[2] = false;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
