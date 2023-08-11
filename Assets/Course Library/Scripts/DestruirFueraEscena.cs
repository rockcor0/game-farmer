using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirFueraEscena : MonoBehaviour
{
    float limiteSuperior = 30.0f;
    float limiteInferior = -25.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > limiteSuperior || transform.position.z < limiteInferior)
        {
            Destroy(gameObject);
        }
    }
}
