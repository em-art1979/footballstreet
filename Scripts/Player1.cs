using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{

    Balon balon;
    PlayerAttack playerAttack;

    GameObject jugador2;

    // Start is called before the first frame update
    void Start()
    {
      this.GetComponent<Movimiento>().enabled = false;

      jugador2 = GameObject.Find("Player 2");
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


    /*private void OnCollisionEnter(Collision collision)*/

    private void OnTriggerEnter(Collider other)
      {

        /*if (collision.gameObject.tag == "Ball")*/
         if(other.gameObject.tag == "Ball")

         {


          this.GetComponent<Movimiento>().enabled = true;

           /*gameObject.transform.parent = transform;*/

           balon=FindObjectOfType<Balon>();
           balon.IsControllingPlayer1=true;


           playerAttack=FindObjectOfType<PlayerAttack>();
           playerAttack.Player1Selected=true;



           if(Input.GetKey(KeyCode.R))

           {

             transform.LookAt(jugador2.transform);

           }


         }


       }


      /*private void OnCollisionExit(Collision collision)*/

      private void OnTriggerExit(Collider other)
      {



                       balon=FindObjectOfType<Balon>();
                       balon.IsControllingPlayer1=false;

                       playerAttack=FindObjectOfType<PlayerAttack>();
                       playerAttack.Player1Selected=false;


        }

}
