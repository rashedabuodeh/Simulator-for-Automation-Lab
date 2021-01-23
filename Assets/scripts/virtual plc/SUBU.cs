using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SUBU : MonoBehaviour
{
    Transform inputfield0;
    Transform inputfield1;
    Transform inputfield2;
    int result;
    
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Run_button").GetComponent<Run>().run)
        {
            int address0 = int.Parse(inputfield0.GetComponent<InputField>().text.Substring(1));
            int address1 = int.Parse(inputfield1.GetComponent<InputField>().text.Substring(1));
            int address2 = int.Parse(inputfield2.GetComponent<InputField>().text.Substring(1));
            result = GameObject.Find("ProgrammingArea").GetComponent<PLC>().D[address0] - GameObject.Find("ProgrammingArea").GetComponent<PLC>().D[address1];
            if (result < 0)
            {
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().F["carry"] = true;
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().D[address2] = 0;
            }
            else if (result == 0)
            {
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().F["zero"] = true;
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().D[address2] = 0; 
            }

            else
            {
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().D[address2] = result;
            }
        }

        else
        {
            inputfield0 = transform.GetChild(0);
            inputfield1 = transform.GetChild(1);
            inputfield2 = transform.GetChild(2);
        }
    }
}
