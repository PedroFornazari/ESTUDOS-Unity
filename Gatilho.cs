using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gatilho : MonoBehaviour
{
    public GameObject obj;
    public Color cor1;
    public Color cor2;
    public Color cor3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter()
    {
        print("Colidiu!");
        obj.GetComponent<Renderer>().material.color = cor1;
    }

    private void OnTriggerExit()
    {
        print("Saiu!");
        obj.GetComponent<Renderer>().material.color = cor3;
    }

    private void OnTriggerStay()
    {
        if(obj.GetComponent<Renderer>().material.color != cor2)
        {
            print("Trocou!");
            obj.GetComponent<Renderer>().material.color = cor2;
        }
    }
}
