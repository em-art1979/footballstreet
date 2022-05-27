using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float velocidad;
    public float velocidadRotacion;

    GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
     ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Input.GetAxis("Horizontal") * velocidad, 0, Input.GetAxis("Vertical") * velocidad);
        transform.LookAt(ball.transform);
        /*transform.Rotate(0,Input.GetAxis("Horizontal") * velocidadRotacion, 0);*/


    }

}
