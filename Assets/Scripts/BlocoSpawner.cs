using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocoSpawner : MonoBehaviour
{
    public GameObject Bloco;
    GameManager gm;

    void Start()
    {
        gm = GameManager.GetInstance();
        GameManager.changeStateDelegate += Construir;
        Construir();
    }

    void Construir()
    {
        if (gm.gameState == GameManager.GameState.GAME)
        {
            for (int i = 0; i < 8; i++)
            // for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 4; j++)
                // for (int j = 0; j < 1; j++)
                {
                    Vector3 posicao = new Vector3(-7 + 2.0f * i, 4.0f - 0.8f * j);
                    // Vector3 posicao = new Vector3(0, 0);

                    Instantiate(Bloco, posicao, Quaternion.identity, transform);
                }
            }
        }
    }

    void Update()
    {
        if (transform.childCount <= 0 && gm.gameState != GameManager.GameState.MENU)
        {
            gm.ChangeState(GameManager.GameState.ENDGAME);
        }
        if (transform.childCount <= 0 && gm.gameState == GameManager.GameState.MENU)
        {
            foreach (Transform child in transform)
            {
                GameObject.Destroy(child.gameObject);
            }
        }
    }

}
