﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Som_Coletar : MonoBehaviour
{
    
   

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Jogador"))  
        {
            GetComponent<AudioSource>().Play();
        }
    }
}
