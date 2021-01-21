using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class creatingpanels : MonoBehaviour
{
    public GameObject panel1= null;
    public GameObject panel2 = null;
    public GameObject panel3 = null;
    public GameObject panel4 = null;
    public GameObject panel5 = null;
    public GameObject panel6 = null;



    public void panel1CREATE()

    {
        Destroy(GameObject.Find("Canvas/menu/Basic/Panel 1(Clone)"));
        
            GameObject.Instantiate(panel1, GameObject.FindGameObjectWithTag("Basic").transform);
        
    }
    public void panel2CREATE()

    {
        Destroy(GameObject.Find("Canvas/menu/Timers & Counters/Panel 2(Clone)"));

        GameObject.Instantiate(panel2, GameObject.FindGameObjectWithTag("Timers & Counters").transform);

    }
    public void panel3CREATE()

    {
        Destroy(GameObject.Find("Canvas/menu/Bit/Panel 3(Clone)"));

        GameObject.Instantiate(panel3, GameObject.FindGameObjectWithTag("Bit").transform);

    }
    public void panel4CREATE()

    {
        Destroy(GameObject.Find("Canvas/menu/Compare/Panel 4(Clone)"));

        GameObject.Instantiate(panel4, GameObject.FindGameObjectWithTag("Compare").transform);

    }
    public void panel5CREATE()

    {
        Destroy(GameObject.Find("Canvas/menu/Math/Panel 5(Clone)"));

        GameObject.Instantiate(panel5, GameObject.FindGameObjectWithTag("Math").transform);

    }

    public void panel6CREATE()

    {
        Destroy(GameObject.Find("Canvas/menu/simulate/Panel 6(Clone)"));

        GameObject.Instantiate(panel6, GameObject.FindGameObjectWithTag("simulate").transform);

    }


    //-------------------------------------------destroying_panels

    public void destroy1()
    {

       Destroy( GameObject.Find("Canvas/menu/Basic/Panel 1(Clone)"));
    }
    public void destroy2()
    {

        Destroy(GameObject.Find("Canvas/menu/Timers & Counters/Panel 2(Clone)"));
    }
    public void destroy3()
    {

        Destroy(GameObject.Find("Canvas/menu/Bit/Panel 3(Clone)"));
    }
    public void destroy4()
    {

        Destroy(GameObject.Find("Canvas/menu/Compare/Panel 4(Clone)"));
    }

    public void destroy5()
    {

        Destroy(GameObject.Find("Canvas/menu/Math/Panel 5(Clone)"));
    }

    public void destroy6()
    {

        Destroy(GameObject.Find("Canvas/menu/simulate/Panel 6(Clone)"));
    }

}
