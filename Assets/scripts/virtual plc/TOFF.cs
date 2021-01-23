using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TOFF : MonoBehaviour
{
    // Start is called before the first frame update
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
            if (GetComponentInParent<Rung_Out>().output )
            {
                acc = 0;
                Debug.Log("out true");
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().T[int.Parse(inputfield0.GetComponent<InputField>().text)] = true;
               
            }
            else if (!GetComponentInParent<Rung_Out>().output && acc <= preset/100) //prest in mili sec
            {
                Debug.Log("start counting");
                acc += Time.deltaTime;
            }
            else
            {
                acc = 0f;
                GameObject.Find("ProgrammingArea").GetComponent<PLC>().T[int.Parse(inputfield0.GetComponent<InputField>().text)] = false;
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
