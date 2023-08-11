using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonajeMover : MonoBehaviour
{
    float movimientoLateral;
    float movimientoVertical;
    float velocidadMovimiento = 5.0f;
    float velocidadGiro = 50.0f;
    public float floatLimiteX = 20.0f;
    public float floatLimiteZ = 20.0f;
    public GameObject pizza;
    public GameObject banano;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
        {
            Instantiate(banano, transform.position + new Vector3(0, 1, 0), pizza.transform.rotation);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //Debug.Log("Lanzamiento pizza");
            Instantiate(pizza, transform.position + new Vector3(0,1,0), pizza.transform.rotation);
        }

        if (transform.position.x < -floatLimiteX)
        {
            transform.position = new Vector3(-floatLimiteX, transform.position.y, transform.position.z);
        }
        if (transform.position.x > floatLimiteX)
        {
            transform.position = new Vector3(floatLimiteX, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -floatLimiteZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y , - floatLimiteZ);
        }
        if (transform.position.z > floatLimiteZ)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, floatLimiteZ);
        }
        movimientoLateral = Input.GetAxis("Horizontal");
        movimientoVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * velocidadMovimiento * movimientoVertical);
        transform.Rotate(Vector3.up * Time.deltaTime * velocidadGiro * movimientoLateral);
    }

}
