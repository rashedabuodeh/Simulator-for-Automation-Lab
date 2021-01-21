using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.UI;

public class Build : MonoBehaviour
{
    public List<List<string>> program = new List<List<string>>();
    public List<Transform> Rungs_output = new List<Transform>();
    public void build()
    {
        var Rungs = GameObject.FindGameObjectsWithTag("Input_Panel");
        foreach(var rung in Rungs)
        {

            List<string> this_rung = new List<string>();
            //Transform input_panel = rung.transform.GetChild(0);
            foreach (Transform child in rung.transform)
            {
                
                if (child.tag == "OR")
                {
                    this_rung.Add(parallel(child));
                }
                else if (child.tag.Substring(0, 1) == ":") 
                {
                    this_rung.Add(reconize_compare(child));
                }
                else
                {
                    this_rung.Add(reconize_instruction(child));
                }
            }
            program.Add(this_rung);

            Transform parent = rung.transform.parent;
            Rungs_output.Add(parent.GetChild(1));
        }
    }
    string reconize_instruction (Transform instruction)   //return a list of string "this_instruction" depending on the gameobject "instruction"
    {
        
        string this_instruction = instruction.tag + instruction.GetComponentInChildren<InputField>().text;
        Debug.Log(this_instruction);

        return this_instruction;
    }

    string parallel (Transform OR)
    {
        string OR_out = "OOR";
        foreach (Transform minirung in OR)
        {
            OR_out += "|";
            foreach (Transform instruction in minirung)
            {
                OR_out += "&" + instruction.tag;
                OR_out += instruction.GetComponentInChildren<InputField>().text;
            }
        }
        Debug.Log(OR_out);
        return OR_out;

    }
    string reconize_compare(Transform instruction)
    {
        string address1 = instruction.GetChild(0).GetComponent<InputField>().text;
        string address2 = instruction.GetChild(1).GetComponent<InputField>().text;
        string this_compare = instruction.tag+address1 + ":" + address2;
        Debug.Log(this_compare);
        return this_compare;
    }
}
