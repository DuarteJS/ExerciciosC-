using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//(Placar final) Crie um script que l� o placar de uma partida entre
//time A e time B. Depois, escreva no console qual dos tr�s
//resultados poss�veis aconteceu: vit�ria do time A, vit�ria do time B
//ou empate. Se o empate teve mais de 3 pontos para cada lado,
//escreva que foi �um empate emocionante�.


public class ex09 : MonoBehaviour
{
  [SerializeField] int placarTimeA;
    [SerializeField]  int placarTimeB;

    // Start is called before the first frame update
    void Start()
    {
        placarTimeA = UnityEngine.Random.Range(1, 5);
        placarTimeB= UnityEngine.Random.Range(1, 5);

        if (placarTimeA > placarTimeB)
        {
            print("Vit�ria do time A");
        }
        else if(placarTimeB > placarTimeA)
        {
            print("Vit�ria do time B");
        }
        else
        {
            if (placarTimeA > 3 && placarTimeB > 3)
            {
                print("Foi um empate emocionante");


            }
            else
            {
                print("Foi um empate");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
