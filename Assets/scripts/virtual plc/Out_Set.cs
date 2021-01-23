using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Out_Set : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Run_button").GetComponent<Run>().run && GetComponentInParent<Rung_Out>().output)
        {
            string _inoutfield = GetComponentInChildren<InputField>().text;
            string address0 = _inoutfield.Substring(0, 1);
            int address1 = int.Parse(_inoutfield.Substring(1));
            if (address0 == "P")
            {
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[address1] = true;
            }
            else if (address0 == "M")
            {
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().M[address1] = true;
            }
        }
    }
}
