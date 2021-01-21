using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fetch : MonoBehaviour
{
    public bool[] P = GameObject.Find("ProgrammingArea").GetComponent<PLC>().P;
    public bool[] M = GameObject.Find("ProgrammingArea").GetComponent<PLC>().M;

}
