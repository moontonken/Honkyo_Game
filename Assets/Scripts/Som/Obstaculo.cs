using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)

        // Musica começa a tocar quando nos aproximamos do obstaculo
    {
        if (other.CompareTag("SoundTrigger"))
        {
            other.GetComponent<AudioSource>().Play();
        }

        if (other.CompareTag("Sound_Inimigo"))
        {
            other.GetComponent<AudioSource>().Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("SoundTrigger"))
        {
            other.GetComponent<AudioSource>().Stop();
        }

        if (other.CompareTag("Sound_Inimigo"))
        {
            other.GetComponent<AudioSource>().Stop();
        }
    }
}
