﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePersonagem : MonoBehaviour
{
    public float vel;
    public static Vector2 direcao;
    //public Animator anim;
    public string dir;

    // Start is called before the first frame update
    void Start()
    {
        //vel = 7f;
        direcao = Vector2.zero;

    }

    // Update is called once per frame
    void Update()
    {
        InputPersonagem();
        transform.Translate(direcao * vel * Time.deltaTime);

        /*if (direcao.x != 0 || direcao.y != 0)
        {
            Animacao(direcao);
        }
        else
        {
            anim.SetLayerWeight(1, 0);
        }*/

        if (Cima.pressionando)
        {
            direcao += Vector2.up;
            transform.Translate(new Vector2(0,vel * Time.deltaTime));
            
        }
        if (Baixo.pressionando)
        {
            direcao += Vector2.down;
            transform.Translate(new Vector2(0, -1 * vel * Time.deltaTime));
            
        }
        if (Direita.pressionando)
        {
            direcao += Vector2.right;
            transform.Translate(new Vector2(vel * Time.deltaTime, 0));
            
        }
        if (Esquerda.pressionando)
        {
            direcao += Vector2.left;
            transform.Translate(new Vector2( -1* vel * Time.deltaTime, 0));
            
        }
    }
    

    void InputPersonagem()
    {
        direcao = Vector2.zero;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direcao += Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direcao += Vector2.down;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direcao += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direcao += Vector2.right;
        }

    }


    /*void Animacao(Vector2 dir)
    {
        anim.SetLayerWeight(1, 1);

        anim.SetFloat("x", dir.x);
        anim.SetFloat("y", dir.y);
    }*/
}