﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMechanic : MonoBehaviour {

    Rigidbody2D rb;
    private float dash_velocidade = 50f;
    private float dash_tempo;
    private float startDash = 0.1f;
    private int direcao;
    private int numberofDashes;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dash_tempo = startDash;
        numberofDashes = 30;
        
    }

    // Update is called once per frame
    void Update () {
        Debug.Log(direcao);

		if(direcao == 0)
        {

            if (Input.GetKey(KeyCode.A) && numberofDashes != 0)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    direcao = 1;
                    numberofDashes--;
                }
            }
            else if (Input.GetKey(KeyCode.D) && numberofDashes != 0)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    direcao = 2;
                    numberofDashes--;
                }
            }
            else if (Input.GetKey(KeyCode.W) && numberofDashes != 0)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    direcao = 3;
                    numberofDashes--;
                }
            }
            else if (Input.GetKey(KeyCode.S) && numberofDashes != 0)
            {
                if (Input.GetButtonDown("Fire1"))
                {
                    direcao = 4;
                    numberofDashes--;
                }
            }

        }
        else
        {
            if(dash_tempo <= 0)
            {
                direcao = 0;
                dash_tempo = startDash;
                rb.velocity = Vector2.zero;
            }
            else
            {
                dash_tempo -= Time.deltaTime;

                if(direcao == 1)
                {
                    rb.velocity = Vector2.left * dash_velocidade;
                }
                else if (direcao == 2)
                {
                    rb.velocity = Vector2.right * dash_velocidade;
                }
                else if (direcao == 3)
                {
                    rb.velocity = Vector2.up * dash_velocidade;
                }
                else if (direcao == 4 )
                {
                    rb.velocity = Vector2.down * dash_velocidade;
                }
            }
        }
	}
}
