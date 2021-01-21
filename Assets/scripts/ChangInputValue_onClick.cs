using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangInputValue_onClick : MonoBehaviour
{
   public PLC plc;
    // GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[1]=true ;

 // bool Input1 = GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[18];

    // Start is called before the first frame update
    void Start()
    {

       GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[0] = false;
    }

    // Update is called once per frame
    void Update()
    {
      
        
    }

    public void click()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[0] = true;
    //plc.P[18] = true;
    //  Input1 = plc.P[18];
    }

    public void release()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[0] = false;


    }

}
