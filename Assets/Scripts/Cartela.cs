using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cartela : MonoBehaviour
{
    [SerializeField]
    float tempoCartela = 0f;
    private bool esperaTempo = false;

    // Start is called before the first frame update
    void Start()
    {
        esperaTempo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (esperaTempo)
        {
            tempoCartela = tempoCartela + Time.deltaTime;
            if (tempoCartela >= 7f)
            {
                esperaTempo = false;
                SceneManager.LoadScene("Menu Inicial");

            }

        }
    }
}
