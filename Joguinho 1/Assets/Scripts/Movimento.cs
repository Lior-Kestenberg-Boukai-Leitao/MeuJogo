using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{

    [SerializeField] float mvSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
       PrintInstrucao();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintInstrucao()
    {

        Debug.Log("Bem vindo ao jogo");

    }

    void MovePlayer()
    {

        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * mvSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * mvSpeed;
        transform.Translate(xValue,0,zValue);

    }

}
