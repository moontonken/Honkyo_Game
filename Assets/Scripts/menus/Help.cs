using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Help : MonoBehaviour
{
   
    void Update()
    {
        Loadscene();
    }

    void Loadscene()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("Help");
        }
    }

}
