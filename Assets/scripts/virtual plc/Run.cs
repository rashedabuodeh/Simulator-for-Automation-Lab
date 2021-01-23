using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Run : MonoBehaviour
{

    public Text stoptext;    
    public Text runtext;    

    public bool run = false;
    public void toggole_run()
    {
        run = !run;
    }
    // Update is called once per frame
    void Update()
    {
        if (run)
        {
            stoptext.gameObject.SetActive(true);
            runtext.gameObject.SetActive(false);


            List<List<string>> program = GameObject.Find("Build_button").GetComponent<Build>().program;
            List<Transform> Rung_out = GameObject.Find("Build_button").GetComponent<Build>().Rungs_output;
            PLC current_stat = GameObject.Find("ProgrammingArea").GetComponent<PLC>();  //Fetching vertual PLC memory   

            int index = 0;
            foreach (List<string> rung in program)
            {
                
                Rung_out[index].GetComponent<Rung_Out>().output = Examine(rung, current_stat);
                index += 1;
            }


        }
        if (!run)
        {
            stoptext.gameObject.SetActive(false);
            runtext.gameObject.SetActive(true);
        }
    }
    bool Examine(List<string> rung, PLC current_stat)
    {
        List<bool> this_rung = new List<bool>();
        bool this_output = true;
        foreach (string instruction in rung)
        {
               //substring if the address is passe with later "P0001"
            if (instruction.Substring(0,3) == "XIC")
            {
                if (instruction.Substring(3, 1) == "P")
                {
                    this_rung.Add(current_stat.P[Int32.Parse(instruction.Substring(4))]);
                }
                else if (instruction.Substring(3, 1) == "T")
                {
                    this_rung.Add(current_stat.T[Int32.Parse(instruction.Substring(4))]);
                }
                else if (instruction.Substring(3, 1) == "C")
                {
                    this_rung.Add(current_stat.C[Int32.Parse(instruction.Substring(4))]);
                }
                else if (instruction.Substring(3, 1) == "M")
                {
                    this_rung.Add(current_stat.M[Int32.Parse(instruction.Substring(4))]);
                }
            }
            else if (instruction.Substring(0, 3) == "XIO")
            {
                if (instruction.Substring(3, 1) == "P")
                {
                    this_rung.Add(!current_stat.P[Int32.Parse(instruction.Substring(4))]);
                }
                else if (instruction.Substring(3, 1) == "T")
                {
                    this_rung.Add(!current_stat.T[Int32.Parse(instruction.Substring(4))]);
                }
                else if (instruction.Substring(3, 1) == "C")
                {
                    this_rung.Add(!current_stat.C[Int32.Parse(instruction.Substring(4))]);
                }
                else if (instruction.Substring(3, 1) == "M")
                {
                    this_rung.Add(!current_stat.M[Int32.Parse(instruction.Substring(4))]);
                }
            }
            //use the adress insted of comparing them
            else if (instruction.Substring(0, 3) == ":<<")
            {
                Debug.Log(int.Parse(instruction.Substring(3).Split(':')[0])<int.Parse(instruction.Substring(3).Split(':')[1]));
            }
            else if (instruction.Substring(0, 3) == ":<=")
            {
                Debug.Log(int.Parse(instruction.Substring(3).Split(':')[0]) <= int.Parse(instruction.Substring(3).Split(':')[1]));
            }
            else if (instruction.Substring(0, 3) == ":>>")
            {
                Debug.Log(int.Parse(instruction.Substring(3).Split(':')[0]) > int.Parse(instruction.Substring(3).Split(':')[1]));
            }
            else if (instruction.Substring(0, 3) == ":<=")
            {
                Debug.Log(int.Parse(instruction.Substring(3).Split(':')[0]) <= int.Parse(instruction.Substring(3).Split(':')[1]));
            }
            else if (instruction.Substring(0, 3) == ":==")
            {
                Debug.Log(int.Parse(instruction.Substring(3).Split(':')[0]) == int.Parse(instruction.Substring(3).Split(':')[1]));
            }
            //use the address insted of comparing them
            else if (instruction.Substring(0, 3) == "OOR")
            {
                this_rung.Add(do_or(instruction, current_stat));
                Debug.Log(do_or(instruction, current_stat));
            }
            
            
        }
        if (this_rung.Contains(false))
        {
            this_output = false;
        }
        return this_output;
    }

    bool do_or (string OR_content, PLC current_stat)
    {
        List<bool> minirungs_out = new List<bool>();
        string[] x = OR_content.Split('|');
        foreach (string minirung in x.ToList().Skip(1))
        {
            string[] instructions = minirung.Split('&');
            List<string> this_minirung = new List<string>();
            foreach (string instruction in instructions.Skip(1))
            {
                this_minirung.Add(instruction);
            }
            minirungs_out.Add(Examine(this_minirung, current_stat));

            
        }
        if (minirungs_out.Contains(true))
        {
            return true;
        }
        return false;
    }
    
    
}
