using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

//(Verificar item de invent�rio) Um jogador possui itens limitados
//no invent�rio. Verifique se o jogador possui uma "Po��o de Vida".
//Se possuir, exiba "Usando Po��o de Vida"; caso contr�rio, "Po��o
//indispon�vel".



public class ex04 : MonoBehaviour
{
    bool pocaodevida;
    bool pocaoindisponivel;

    // Start is called before the first frame update
    void Start()
    {
        if (pocaodevida)
        {
            print("Usando po��o de vida");

        }
        else 
        {
            print("Po��o indisponivel.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
