using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    public GameObject[] animales;
    public int index;
    Vector3 vector;

    float retardoInicial = 2f;
    float intervaloGeneracion = 1f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarAnimalAleatorio", retardoInicial, intervaloGeneracion);
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyUp(KeyCode.Q))
        //{
        //    GenerarAnimalAleatorio();
        //}


    }

    void GenerarAnimalAleatorio()
    {
        if (index == 0)
        {
            vector = new Vector3(-12, 0, 22);
        }
        if (index == 1)
        {
            vector = new Vector3(0, 0, 14);
        }
        if (index == 2)
        {
            vector = new Vector3(12, 0, 22);
        }

        Instantiate(animales[index], vector, animales[index].transform.rotation);

        if (index >= 2)
        {
            index = -1;
        }
        index++;
    }
}
