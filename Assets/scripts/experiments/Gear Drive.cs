using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearDrive : MonoBehaviour
{
    public GameObject Gear1;
    public GameObject door;

    // Start is called before the first frame update
    void Start()
    {
        Gear1.transform.Rotate(0, 0, 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
