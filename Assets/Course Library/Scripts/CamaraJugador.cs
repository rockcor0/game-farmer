using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraJugador : MonoBehaviour
{

    private Vector3 desplazamiento = new Vector3(0, 12, -15);
    public GameObject Jugador;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Jugador.transform.position + desplazamiento;
    }
}
