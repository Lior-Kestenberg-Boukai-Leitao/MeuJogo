using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pontos : MonoBehaviour
{
    
    int hits = -1;
    
    private void OnCollisionEnter(Collision other)
    {
        hits++;
        Debug.Log("você bateu tantas vezes: " + hits);
    }

}
