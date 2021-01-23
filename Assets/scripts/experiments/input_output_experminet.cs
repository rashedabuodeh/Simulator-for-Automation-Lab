using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class input_output_experminet : MonoBehaviour
{
    public Sprite ONSprite;
    public Sprite OFFSprite;


    public void Update()

    {
        if (gameObject.name == "out_exp")
        {
            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[16]) // Red light 16 , orng 17 , green 18 
            {
                GetComponent<Image>().sprite = ONSprite;
            }
            if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[16])
            {
                GetComponent<Image>().sprite = OFFSprite;

            }
        }

        if (gameObject.name == "out_exp (1)")
        {
            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[17]) // Red light 16 , orng 17 , green 18 
            {
                GetComponent<Image>().sprite = ONSprite;
            }
            if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[17])
            {
                GetComponent<Image>().sprite = OFFSprite;
            }
        }

        if (gameObject.name == "out_exp (2)")
        {
            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[18]) // Red light 16 , orng 17 , green 18 
            {
                GetComponent<Image>().sprite = ONSprite;
            }
            if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[18])
            {
                GetComponent<Image>().sprite = OFFSprite;
            }
        }
        /////
        if (gameObject.name == "out_exp (3)")
        {
            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[19]) // Red light 16 , orng 17 , green 18 
            {
                GetComponent<Image>().sprite = ONSprite;

            }
            if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[19])
            {
                GetComponent<Image>().sprite = OFFSprite;
            }
        }

        if (gameObject.name == "out_exp (4)")
        {
            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[20]) // Red light 16 , orng 17 , green 18 
            {
                GetComponent<Image>().sprite = ONSprite;

            }
            if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[20])
            {
                GetComponent<Image>().sprite = OFFSprite;
            }
        }

        if (gameObject.name == "out_exp (5)")
        {
            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[21]) // Red light 16 , orng 17 , green 18 
            {
                GetComponent<Image>().sprite = ONSprite;

            }
            if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[21])
            {
                GetComponent<Image>().sprite = OFFSprite;
            }
        }
        ////////
        if (gameObject.name == "out_exp (6)")
        {
            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[22]) // Red light 16 , orng 17 , green 18 
            {
                GetComponent<Image>().sprite = ONSprite;

            }
            if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[22])
            {
                GetComponent<Image>().sprite = OFFSprite;
            }
        }

        if (gameObject.name == "out_exp (7)")
        {
            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[23]) // Red light 16 , orng 17 , green 18 
            {
                GetComponent<Image>().sprite = ONSprite;

            }
            if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[23])
            {
                GetComponent<Image>().sprite = OFFSprite;
            }
        }

        if (gameObject.name == "out_exp (8)")
        {
            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[24]) // Red light 16 , orng 17 , green 18 
            {
                GetComponent<Image>().sprite = ONSprite;

            }
            if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[24])
            {
                GetComponent<Image>().sprite = OFFSprite;
            }
        }
        /////////
        ///
        if (gameObject.name == "out_exp (9)")
        {

            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[25]) // Red light 16 , orng 17 , green 18 
            {
                GetComponent<Image>().sprite = ONSprite;

            }
            if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[25])
            {
                GetComponent<Image>().sprite = OFFSprite;
            }
        }



        if (gameObject.name == "out_exp (10)")
        {

            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[26]) // Red light 16 , orng 17 , green 18 
            {
                GetComponent<Image>().sprite = ONSprite;

            }
            if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[26])
            {
                GetComponent<Image>().sprite = OFFSprite;
            }
        }

        if (gameObject.name == "out_exp (11)")
        {

            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[27]) // Red light 16 , orng 17 , green 18 
            {
                GetComponent<Image>().sprite = ONSprite;

            }
            if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[27])
            {
                GetComponent<Image>().sprite = OFFSprite;
            }
        }
        ///////
        if (gameObject.name == "out_exp (12)")
        {

            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[28]) // Red light 16 , orng 17 , green 18 
            {
                GetComponent<Image>().sprite = ONSprite;

            }
            if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[28])
            {
                GetComponent<Image>().sprite = OFFSprite;
            }
        }


        if (gameObject.name == "out_exp (13)")
        {

            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[29]) // Red light 16 , orng 17 , green 18 
            {
                GetComponent<Image>().sprite = ONSprite;

            }
            if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[29])
            {
                GetComponent<Image>().sprite = OFFSprite;
            }
        }

        if (gameObject.name == "out_exp (14)")
        {

            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[30]) // Red light 16 , orng 17 , green 18 
            {
                GetComponent<Image>().sprite = ONSprite;

            }
            if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[30])
            {
                GetComponent<Image>().sprite = OFFSprite;
            }
        }

        if (gameObject.name == "out_exp (15)")
        {

            if (GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[31]) // Red light 16 , orng 17 , green 18 
            {
                GetComponent<Image>().sprite = ONSprite;

            }
            if (!GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[31])
            {
                GetComponent<Image>().sprite = OFFSprite;
            }
        }
    }


    public void Pressed()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[0] = true;

    }
    public void released()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[0] = false;
    }
    public void Pressed1()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[1] = true;

    }
    public void released1()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[1] = false;
    }

    public void Pressed2()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[2] = true;

    }
    public void released2()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[2] = false;
    }

    ///////////////

    public void Pressed3()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[3] = true;

    }
    public void released3()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[3] = false;
    }



    public void Pressed4()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[4] = true;

    }
    public void released4()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[4] = false;
    }



    public void Pressed5()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[5] = true;

    }
    public void released5()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[5] = false;
    }


    /////////
    public void Pressed6()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[6] = true;

    }
    public void released6()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[6] = false;
    }

    public void Pressed7()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[7] = true;

    }
    public void released7()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[7] = false;
    }

    public void Pressed8()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[8] = true;

    }
    public void released8()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[8] = false;
    }


    ///////////
    ///
    public void Pressed9()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[9] = true;

    }
    public void released9()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[9] = false;
    }


    public void Pressed10()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[10] = true;

    }
    public void released10()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[10] = false;
    }


    public void Pressed11()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[11] = true;

    }
    public void released11()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[11] = false;
    }
    /// <summary>
    /// /////
    /// </summary>
    public void Pressed12()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[12] = true;

    }
    public void released12()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[12] = false;
    }
    public void Pressed13()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[13] = true;

    }
    public void released13()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[13] = false;
    }
    public void Pressed14()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[14] = true;

    }
    public void released14()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[14] = false;
    }

    public void Pressed15()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[15] = true;

    }
    public void released15()
    {
        GameObject.Find("ProgrammingArea").GetComponent<PLC>().P[15] = false;
    }
}






