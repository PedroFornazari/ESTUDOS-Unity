using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Luzes : MonoBehaviour
{
    private Light verdinha;
    public float contagem = 3.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        verdinha = this.GetComponent<Light>();
        verdinha.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        contagem -= Time.deltaTime;
        if(contagem <= 0.0f)
        {
            verdinha.enabled = true;
        }
    }
}
