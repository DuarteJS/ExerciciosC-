using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//(Pontua��o de miss�o) Ap�s completar uma miss�o, o jogador
//recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
//exiba "Miss�o bem-sucedida"; caso contr�rio, "Miss�o
//incompleta".

public class ex05 : MonoBehaviour
{
    int pontosAtual = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        if (pontosAtual > 50)
        {
        print("Miss�o bem-sucedida");
        }
        else
        {
            print("Miss�o incompleta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
