using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseAddressValue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void click()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[1] = true;
        //plc.P[18] = true;
        //  Input1 = plc.P[18];
    }

    public void release()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[1] = false;


    }

}
