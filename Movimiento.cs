using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public float velocidadNormal;
    public float velocidadSprint;


    GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
     ball = GameObject.Find("Ball");
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Input.GetAxis("Horizontal") * velocidadNormal, 0, Input.GetAxis("Vertical") * velocidadNormal);
        transform.LookAt(ball.transform);

        if(Input.GetKey(KeyCode.Space))

        {


          transform.Translate(Input.GetAxis("Horizontal") * velocidadSprint, 0, Input.GetAxis("Vertical") * velocidadSprint);
          transform.LookAt(ball.transform);



        }
    }

}
