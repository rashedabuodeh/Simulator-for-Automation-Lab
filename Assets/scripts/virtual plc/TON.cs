using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TON : MonoBehaviour
{

    Transform inputfield0;
    Transform inputfield1;
    float acc = 0f;
    float preset = 0f;
    float value;

    private void Start()
    {
        inputfield0 = transform.GetChild(0);
        inputfield1 = transform.GetChild(1);
    }
    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Run_button").GetComponent<Run>().run)
        {
            Debug.Log("running");
            if (GetComponentInParent<Rung_Out>().output)
            {
                Debug.Log("out true");
                acc += Time.deltaTime;
                if (acc >= preset/100)    // the preset is  in mili sec
                {
                    Debug.Log("done");
                    GameObject.Find("ProgrammingArea").GetComponent<PLC>().T[int.Parse(inputfield0.GetComponent<InputField>().text)] = true;                     
                }
            }
            else
            {
                Debug.Log("false");
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().T[int.Parse(inputfield0.GetComponent<InputField>().text)] = false;
                acc = 0f;
            }
        }
        else
        {
            inputfield0 = transform.GetChild(0);
            inputfield1 = transform.GetChild(1);
            if (float.TryParse(inputfield1.GetComponent<InputField>().text, out value))
            {
                preset = value;
            }
        }
    }
}
