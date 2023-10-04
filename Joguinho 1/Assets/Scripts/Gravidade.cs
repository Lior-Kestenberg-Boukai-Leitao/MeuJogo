using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravidade : MonoBehaviour
{   

    [SerializeField] float TempoParaCair = 5f;
    MeshRenderer render;
    Rigidbody corpo;

    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        corpo = GetComponent<Rigidbody>();

        render.enabled = false;
        corpo.useGravity = false;

    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > TempoParaCair)
        {
            render.enabled = true;
            corpo.useGravity = true;
        }
    }
}
