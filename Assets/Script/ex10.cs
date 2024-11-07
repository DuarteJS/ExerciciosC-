using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//10. (Itens do inventário) Crie um script onde o jogador pode coletar
//diferentes tipos de itens (como moedas, poções, ou power-ups)
//que têm efeitos diferentes dependendo do tipo coletado. Use um
//switch case para determinar o efeito de cada tipo de item.

public class ex10 : MonoBehaviour
{
    [SerializeField] string tipoItem;
    [SerializeField] int moeda = 10;
    [SerializeField] bool escudo = false;
    [SerializeField] bool pocaoVida = false;


    // Start is called before the first frame update
    void Start()
    {
        switch (tipoItem)
        {
            case "Moedas":
                moeda++;
                print("Moeda coletada" + moeda );
                break;

                case "Escudo";
                escudo = true;
                print("Escudo ativo");
                break;

            case "Poção":
                pocaoVida = true;
                print("Poção de vida coletada ");
                    break;
            default:
                Debug.Log("Item desconhecido");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
