using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour
{

    [SerializeField] float xvel = 0f;
    [SerializeField] float yvel = 1f;
    [SerializeField] float zvel = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xvel,yvel,zvel);
    }
}
