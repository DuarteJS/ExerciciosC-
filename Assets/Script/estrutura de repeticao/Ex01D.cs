using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex01D : MonoBehaviour
{
    [SerializeField] string texto = "Jogos Digitais";
    [SerializeField] int contadorConsoantes;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < texto.Length; i++)
        {
            char Letra = texto[i];

            if ("bcdfghjklmnqprstvwxyz".Contains(char.ToLower(Letra))) //|| "bcdfghjklmnqprstvwxyz".ToUpper().Contains(Letra)
            {
                contadorConsoantes++;
            }
        }

        print("O numero de consoante e: " + contadorConsoantes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
