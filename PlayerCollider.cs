using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{

  Balon balon;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



    }

    /*private void OnTriggerEnter(Collider other)*/
      private void OnCollisionEnter(Collision collision)
        {

          if (collision.gameObject.tag == "Ball")
           {

            this.GetComponent<Movimiento>().enabled = true;

             gameObject.transform.parent = transform;

             balon=FindObjectOfType<Balon>();
             balon.IsControlling=true;

           }




/*
          if(other.name == "Ball")
          {
            other.transform.parent = transform;
          }
*/



        }




        private void OnCollisionExit(Collision collision)
            {



                balon=FindObjectOfType<Balon>();
                balon.IsControlling=false;


            }





}
