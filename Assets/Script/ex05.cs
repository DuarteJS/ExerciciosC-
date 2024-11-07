using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//(Pontuação de missão) Após completar uma missão, o jogador
//recebe pontos. Verifique se ele ganhou mais de 50 pontos. Se sim,
//exiba "Missão bem-sucedida"; caso contrário, "Missão
//incompleta".

public class ex05 : MonoBehaviour
{
    int pontosAtual = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        if (pontosAtual > 50)
        {
        print("Missão bem-sucedida");
        }
        else
        {
            print("Missão incompleta");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
