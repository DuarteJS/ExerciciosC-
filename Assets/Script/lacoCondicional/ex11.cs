using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//(Diálogos)Implemente um sistema de diálogos onde o jogador
//pode interagir com um NPC (personagem não jogável), e o NPC
//responde com diferentes frases dependendo do estado do jogo.
//Use switch case para definir as respostas baseadas no estado do
//jogador.


public class ex11 : MonoBehaviour
{
    [SerializeField] int estado;

    // Start is called before the first frame update
    void Start()
    {
        switch (estado)
        {
            case 1:
                print("Tudo bem?");
            break;

            case 2:
                print("Olà");
            break;
            
            case 3:
                print("Poderia me ajudar.");
            break;           
            
            case 4:
                print("Ca estamos.");
            break;

            default:
                print("Não tenho nada a dizer sobre isso!");
            break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
