using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{

  Balon balon;
  PlayerAttack playerAttack;
  GameObject jugador1;


    // Start is called before the first frame update
    void Start()
    {
      this.GetComponent<Movimiento>().enabled = false;
      jugador1 = GameObject.Find("Player 1");

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnableMovement()

    {
      this.GetComponent<Movimiento>().enabled = true;

    }

    public void DisableMovement()

    {

      this.GetComponent<Movimiento>().enabled = false;
    }
/*
    private void OnCollisionEnter(Collision collision)
      {

        if (collision.gameObject.tag == "Ball")
         {

          this.GetComponent<Movimiento>().enabled = true;

           gameObject.transform.parent = transform;

           balon=FindObjectOfType<Balon>();
           balon.IsControllingPlayer1=true;

           playerAttack=FindObjectOfType<PlayerAttack>();
           playerAttack.Player2Selected=true;

         }


       }


       /*private void OnCollisionEnter(Collision collision)*/

       private void OnTriggerEnter(Collider other)
         {

           /*if (collision.gameObject.tag == "Ball")*/
            if(other.gameObject.tag == "Ball")

            {


             this.GetComponent<Movimiento>().enabled = true;

            /* gameObject.transform.parent = transform;*/

              balon=FindObjectOfType<Balon>();
              balon.IsControllingPlayer2=true;


              playerAttack=FindObjectOfType<PlayerAttack>();
              playerAttack.Player2Selected=true;

              if(Input.GetKey(KeyCode.R))

              {

                transform.LookAt(jugador1.transform);

              }

            }


          }


         /*private void OnCollisionExit(Collision collision)*/

         private void OnTriggerExit(Collider other)
         {



                          balon=FindObjectOfType<Balon>();
                          balon.IsControllingPlayer2=false;

                          playerAttack=FindObjectOfType<PlayerAttack>();
                          playerAttack.Player2Selected=false;


           }
}
