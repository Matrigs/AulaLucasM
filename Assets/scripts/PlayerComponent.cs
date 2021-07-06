using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComponent : MonoBehaviour
{
    public float moveDeitado;

    public float velocidade = 20;

    public bool jumpar = false;

    void Update(){
        moveDeitado = Input.GetAxisRaw("Horizontal") *  velocidade;

        if(Input.GetButtonDown("Jump")){
            jumpar = true;
        }
    }
}
