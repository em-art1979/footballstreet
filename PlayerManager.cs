using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
  public GameObject target;
  public bool IsPlayerSelected;

    // Start is called before the first frame update
    void Awake()

    {
      this.GetComponent<Movimiento>().enabled = false;
    }

    void Start()
    {
      IsPlayerSelected=false;
    }

    // Update is called once per frame
    void Update()
    {

    /*
      if(Input.GetKey("space"))
      {

        this.GetComponent<Movimiento>().enabled = true;
      }
*/

      GameObject[] ball;
      ball = GameObject.FindGameObjectsWithTag("Ball");
      Vector3 shortestDistanceToBall = new Vector3(5, 5, 5);



        for (int i = 0; i < ball.Length; i++)
        {
        Vector3 distanceToBall = transform.position - ball[i].transform.position;
        if (distanceToBall.magnitude < shortestDistanceToBall.magnitude)
        {
        shortestDistanceToBall = transform.position - ball[i].transform.position;
        target = ball[i];

        this.GetComponent<Movimiento>().enabled = true;


        }

        else

        {
          this.GetComponent<Movimiento>().enabled = false;
        }

        }






    }
}
