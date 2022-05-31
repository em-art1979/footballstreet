using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{



    // Start is called before the first frame update
    void Awake()

    {


    }

    void Start()
    {
/*
      this.GetComponent<PlayerAttack>().enabled = false;*/
      this.GetComponent<PlayerDeffend>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {



    }



}
