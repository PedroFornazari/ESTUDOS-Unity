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
        Debug.LogWarning("ATEN��O - O C�digo apresenta uma poss�vel inconsist�ncia!");
        Debug.LogError("ERRO IDENTIFICADO!!!");

    }

    // Update is called once per frame
    void Update()
    {

    }
}
