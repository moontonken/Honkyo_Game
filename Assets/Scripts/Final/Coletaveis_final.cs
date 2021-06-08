using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class Coletaveis_final : MonoBehaviour
{
    [SerializeField] 
    float tempoVitoria = 0f;
    private bool contarTempo = false;

    private Animator coletaveis;

    private void Start()
    {
        coletaveis = GetComponent<Animator>();
     

    }

   
    private void Update()
    {
        Animacao();
    }

    void Animacao()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {

            Debug.Log("animar");
            coletaveis.SetBool("playAnimacao", true);

            contarTempo = true;
        }
            if (contarTempo)
            {
                tempoVitoria = tempoVitoria + Time.deltaTime;
                if ( tempoVitoria >=5f)
                    {
                    contarTempo = false;
                    SceneManager.LoadScene("Victory");

                }
                
            }
        
        
    }

}

  
