using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControler2d : MonoBehaviour
{
    public float veHo = 10f;

    public float alturaPulo = 16f;

    private Rigidbody2D rizin;

    private bool indicandoDireita = true;

    public LayerMask graunmd;

    private Transform chekachao;

    public float chekaraio = 0.2f;

    public bool nochao;

    private void Awake(){
        chekachao = transform.Find("penochao");
        rizin = GetComponent <Rigidbody2D>();
    }

    private void FixedUpdate(){
        //cria um circulo a partir do pé do player(chekachao), com um certo raio(chekaraio), detectando a camada do chão(graunmd)
        // um raio é a distancia entre o centro de um circulo e sua borda
        Collider2D[]colliders = Physics2D.OverlapCircleAll(chekachao.position,chekaraio,graunmd);

        //esse codigo vai rodar enquanto o numero de loops for menor que a quantidade de colliders do chão detectados
        // 1 loop é = a quantas vezes o codigo passou por dentro do for
        // a cada loop, o numero de loops(i aumenta em 1) 
        for(int i = 0; i < colliders.Length; i++)
        {
            if(colliders[i].gameObject != gameObject)
            {
                nochao = true;
            }
        }
    }

    public void Move(float directions, bool jump)
    {
        rizin.velocity = new Vector2(directions * veHo, rizin.velocity.y);
        private float moVe = Input.GetAxis("Vertical");
        if (jump == true&& nochao == true)
        {
            nochao = false;
            rizin.AddForce(new Vector2(0f,alturaPulo));
        }
    }
}