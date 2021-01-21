using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MOV : MonoBehaviour
{
    Transform inputfield0;
    Transform inputfield1;
    string hex_value;
    // Update is called once per frame
    void Update()
    {

        if (GameObject.Find("Run_button").GetComponent<Run>().run)
        {
            if (inputfield0.GetComponent<InputField>().text.Substring(0, 1) == "H")
            {
                int d_value = Convert.ToInt32(hex_value, 16);
                int d_address = int.Parse(inputfield1.GetComponent<InputField>().text.Substring(1));
                hex_value = inputfield0.GetComponent<InputField>().text.Substring(1);
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().D[d_address] = d_value;


                Debug.Log(inputfield1.GetComponent<InputField>().text.Substring(1));
                Debug.Log(hex_value);
                Debug.Log(Convert.ToInt32(hex_value, 16));
            }
            if (inputfield0.GetComponent<InputField>().text.Substring(0, 1) == "D")
            {
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().D[int.Parse(inputfield1.GetComponent<InputField>().text.Substring(1))] = GameObject.Find("ProgrammingArea").GetComponent<PLC>().D[int.Parse(inputfield0.GetComponent<InputField>().text.Substring(1))];
            }

        }
        else
        {
            inputfield0 = transform.GetChild(0);
            inputfield1 = transform.GetChild(1);
        }

    }
}
