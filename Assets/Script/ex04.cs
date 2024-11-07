using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

//(Verificar item de inventário) Um jogador possui itens limitados
//no inventário. Verifique se o jogador possui uma "Poção de Vida".
//Se possuir, exiba "Usando Poção de Vida"; caso contrário, "Poção
//indisponível".



public class ex04 : MonoBehaviour
{
    bool pocaodevida;
    bool pocaoindisponivel;

    // Start is called before the first frame update
    void Start()
    {
        if (pocaodevida)
        {
            print("Usando poção de vida");

        }
        else 
        {
            print("Poção indisponivel.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
