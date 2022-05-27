using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balon : MonoBehaviour
{
    // Start is called before the first frame update
    public int fuerzaTiro;
    public int fuerzaPase;
    public bool IsControlling;
    PlayerManager playerManager;
    /*GameObject jugador2;*/

    void Start()
    {

      IsControlling=false;

      /*jugador2 = GameObject.Find("Player 2");*/
    }

    // Update is called once per frame
    void Update()
    {
      if(IsControlling==true)

      {

/*
        playerManager=FindObjectOfType<PlayerManager>();
        playerManager.IsPlayerSelected=true;
*/

        if(Input.GetKey(KeyCode.F))
        {
            GetComponent<Rigidbody>().AddForce(0,0,fuerzaTiro);
        }
        if(Input.GetKey(KeyCode.R))

         {
             GetComponent<Rigidbody>().velocity = transform.forward * 20;


         }
      }

    }



}
