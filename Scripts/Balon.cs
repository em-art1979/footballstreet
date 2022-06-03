using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balon : MonoBehaviour
{
    // Start is called before the first frame update
    public int fuerzaTiro;
    public int fuerzaPase;
    public bool IsControllingPlayer1;
    public bool IsControllingPlayer2;
    PlayerManager playerManager;

    GameObject jugador1;
    GameObject jugador2;

    void Start()
    {

      IsControllingPlayer1=false;
      IsControllingPlayer2=false;
      jugador1 = GameObject.Find("Player 1");
      jugador2 = GameObject.Find("Player 2");
    }

    // Update is called once per frame
    void Update()
    {
      if(IsControllingPlayer1==true)

      {




        if(Input.GetKey(KeyCode.F))
        {


            GetComponent<Rigidbody>().AddForce(0,0,fuerzaTiro);


        }




        if(Input.GetKey(KeyCode.R))

        {


            GetComponent<Rigidbody>().velocity = transform.forward * 20;




        }



/*

        else if(Input.GetKey(KeyCode.R))

        {

            transform.LookAt(jugador1.transform);


        }

*/
      }


      if(IsControllingPlayer2==true)

      {


        if(Input.GetKey(KeyCode.F))
        {


            GetComponent<Rigidbody>().AddForce(0,0,fuerzaTiro);


        }




        if(Input.GetKey(KeyCode.R))

        {

            GetComponent<Rigidbody>().velocity = transform.forward * 20;


        }
/*
        else if(Input.GetKey(KeyCode.R))

        {

          transform.LookAt(jugador2.transform);

        }
*/



    }


  }



}
