using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scenes_manager : MonoBehaviour
{
    public void scene1()
    {
        //GameObject.Destroy(GameObject.Find(Conveyor_belt));
        if (SceneManager.GetSceneByName("garage_door").isLoaded == false)
        {
            if (SceneManager.GetSceneByName("Conveyor_belt").isLoaded == true)
            {
                SceneManager.UnloadSceneAsync("Conveyor_belt");
            }
            if (SceneManager.GetSceneByName("Traffic_Lights").isLoaded == true)
            {
                SceneManager.UnloadSceneAsync("Traffic_Lights");
            }
            if (SceneManager.GetSceneByName("IO_experiment").isLoaded == true)
            {
                SceneManager.UnloadSceneAsync("IO_experiment");
            }
            /////////////////
            SceneManager.LoadScene("garage_door", LoadSceneMode.Additive);
        }
    }
    public void scene2()
    {
        if (SceneManager.GetSceneByName("Conveyor_belt").isLoaded == false)
        {
            if (SceneManager.GetSceneByName("garage_door").isLoaded == true)
            {
                SceneManager.UnloadSceneAsync("garage_door");
            }

            if (SceneManager.GetSceneByName("Traffic_Lights").isLoaded == true)
            {
                SceneManager.UnloadSceneAsync("Traffic_Lights");
            }
            if (SceneManager.GetSceneByName("IO_experiment").isLoaded == true)
            {
                SceneManager.UnloadSceneAsync("IO_experiment");
            }
            ///////////////
            SceneManager.LoadScene("Conveyor_belt", LoadSceneMode.Additive);
        }
    }

    public void scene3()
    {
        if (SceneManager.GetSceneByName("Traffic_Lights").isLoaded == false)
        {
            if (SceneManager.GetSceneByName("garage_door").isLoaded == true)
            {
                SceneManager.UnloadSceneAsync("garage_door");
            }

            if (SceneManager.GetSceneByName("Conveyor_belt").isLoaded == true)
            {
                SceneManager.UnloadSceneAsync("Conveyor_belt");
            }

            if (SceneManager.GetSceneByName("IO_experiment").isLoaded == true)
            {
                SceneManager.UnloadSceneAsync("IO_experiment");
            }
            ////////////////
            SceneManager.LoadScene("Traffic_Lights", LoadSceneMode.Additive);
        }
    }

    public void scene4()
    {
        if (SceneManager.GetSceneByName("IO_experiment").isLoaded == false)
        {
            if (SceneManager.GetSceneByName("garage_door").isLoaded == true)
            {
                SceneManager.UnloadSceneAsync("garage_door");
            }

            if (SceneManager.GetSceneByName("Conveyor_belt").isLoaded == true)
            {
                SceneManager.UnloadSceneAsync("Conveyor_belt");
            }
            if (SceneManager.GetSceneByName("Traffic_Lights").isLoaded == true)
            {
                SceneManager.UnloadSceneAsync("Traffic_Lights");
            }
            ////////////////
            SceneManager.LoadScene("IO_experiment", LoadSceneMode.Additive);
        }
    }

}
