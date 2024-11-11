using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//(Escolha de personagem) O jogador pode escolher entre o
//personagem Guerreiro ou Mago. Exiba "Guerreiro escolhido" se o
//jogador selecionar Guerreiro e "Mago escolhido" se selecionar
//Mago.

public class ex06 : MonoBehaviour
{
    int jogador1 ;
    int jogador2 ;
    // Start is called before the first frame update
    void Start()
    {
        if (jogador1 == 1)
        {
            print("Guerreiro escolhido");
        }
        else
        {
            print("Mago escolhido");
        }
            
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
