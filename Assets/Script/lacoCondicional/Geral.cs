using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Geral : MonoBehaviour
{
    //valor inteiro
    int VidaJogador;

    //nuemros querbados 
    float velocidadecarro = 125.5f;

    //numeros quebrados mas com maior armazenamento.
    double Velocidade = 120.3;

    //escrever apelidos com mais de uma letra.
    string nomeJogador = "Tadola";

    //apenas uma letra.
    char apelido = 'T';

    //valores verdadeiros ou falso
    bool vivo = true;

    int vida_jogador;

    void Start()
    {


        Debug.Log(VidaJogador);

        print(velocidadecarro);

        print(vivo);


    }

   
    void Update()
    {
        
    }
}
