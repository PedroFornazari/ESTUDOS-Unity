using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print("O Objeto iniciou - PRINT");
        Debug.Log("O Objeto iniciou - DEBUG");
        Debug.LogWarning("ATENÇÃO - O Código apresenta uma possível inconsistência!");
        Debug.LogError("ERRO IDENTIFICADO!!!");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
