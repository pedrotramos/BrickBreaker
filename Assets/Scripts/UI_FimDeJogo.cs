using UnityEngine;
using UnityEngine.UI;

public class UI_FimDeJogo : MonoBehaviour
{
    public Text message, score;

    GameManager gm;
    private void OnEnable()
    {
        gm = GameManager.GetInstance();

        if (gm.vidas > 0)
        {
            message.text = "Você Ganhou e fez " + gm.pontos.ToString() + " pontos!!!";
        }
        else
        {
            message.text = "Você fez " + gm.pontos.ToString() + " pontos, mas perdeu :(";
        }
    }

    public void Voltar()
    {
        gm.ChangeState(GameManager.GameState.MENU);
    }
}