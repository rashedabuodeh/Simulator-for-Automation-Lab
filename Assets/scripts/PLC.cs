using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLC : MonoBehaviour
{
    public bool[] P = new bool[32];
    public bool[] M = new bool[1024];
    public int[] D = new int[5120];
    public bool[] T = new bool[1024];
    public bool[] C = new bool[1024];
    public Dictionary<string, bool> F = new Dictionary<string, bool>();
    private void Start()
    {
        F.Add("zero", false);
        F.Add("overflow", false);
        F.Add("carry", false);
    }

}






