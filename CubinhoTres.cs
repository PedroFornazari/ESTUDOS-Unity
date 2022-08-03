using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubinhoTres : MonoBehaviour
{
    public float sfrente = 5;
    public float sgirar = 80;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            print("Avante!");
            if (Input.GetKey(KeyCode.LeftShift))
            {
                this.transform.Translate(0, 0, (3 * sfrente * Time.deltaTime));
            }
            else
            {
                this.transform.Translate(0, 0, (sfrente * Time.deltaTime));
            }

        }

        if (Input.GetKey(KeyCode.S))
        {
            print("Para trás!");
            if (Input.GetKey(KeyCode.LeftShift))
            {
                this.transform.Translate(0, 0, (-3 * sfrente * Time.deltaTime));
            }
            else
            {
                this.transform.Translate(0, 0, (-sfrente * Time.deltaTime));
            }

        }

        if (Input.GetKey(KeyCode.A))
        {
            print("Giro Esquerda!");
            this.transform.Rotate(0, (sgirar * Time.deltaTime), 0);

        }
        if (Input.GetKey(KeyCode.D))
        {
            print("Giro Direita!");
            this.transform.Rotate(0, (-sgirar * Time.deltaTime), 0);

        }

    }
}
