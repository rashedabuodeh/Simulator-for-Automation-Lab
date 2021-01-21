using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class normall_out : MonoBehaviour
{
   
    void Update()
    {
        if (GameObject.Find("Run_button").GetComponent<Run>().run)
        {
            string _inoutfield = GetComponentInChildren<InputField>().text;
            string address0 = _inoutfield.Substring(0, 1); 
            int address1 = int.Parse(_inoutfield.Substring(1));
            if(address0 == "P")
            {
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[address1] = GetComponentInParent<Rung_Out>().output;
            }
            else if(address0 == "M")
            {
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().M[address1] = GetComponentInParent<Rung_Out>().output;
            }
        }
        
    }
}
