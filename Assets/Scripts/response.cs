using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class response : MonoBehaviour
{

    public int idCategoria;

    public Text pergunta;
    public Text respostaA;
    public Text respostaB;
    public Text respostaC;
    public Text infoResposta;

    // array que guarda todas as perguntas, respostas e acertos 
    public string[] perguntas;
    public string[] questaoA;
    public string[] questaoB;
    public string[] questaoC;
    public string[] acertos;

    private int idPergunta;
    private float idAcerto;
    private float idQuestao;
    private float mediaAcertos;
    private int notaFinal;


    void Start() 
    {
        idCategoria = PlayerPrefs.GetInt("idCategoria");
        idPergunta = 0;
        idQuestao = perguntas.Length;

        pergunta.text = perguntas[idPergunta];
        respostaA.text = questaoA[idPergunta];
        respostaB.text = questaoB[idPergunta];
        respostaC.text = questaoC[idPergunta];

        infoResposta.text = "Respondendo " + (idCategoria + 1).ToString() + " de " + idQuestao.ToString() + " questões";

    }

    public void resposta(string questao)
    {
        if(questao == "A")
        {
            if (questaoA[idPergunta] == acertos[idPergunta])
            {
                idAcerto += 1;
            }

        }
        else if(questao == "B")
        {

            if (questaoB[idPergunta] == acertos[idPergunta])
            {
                idAcerto += 1;
            }
        }
        else if (questao == "C")
        {
            if (questaoC[idPergunta] == acertos[idPergunta])
            {
                idAcerto += 1;
            }

        }

        proximaQuestao();
    }

    public void proximaQuestao()
    {

        idPergunta += 1;

        if (idPergunta <= (idQuestao - 1))
        {

            pergunta.text = perguntas[idPergunta];
            respostaA.text = questaoA[idPergunta];
            respostaB.text = questaoB[idPergunta];
            respostaC.text = questaoC[idPergunta];

            infoResposta.text = "Respondendo " + (idCategoria + 1).ToString() + " de " + idQuestao.ToString() + " questões";
        }
        else
        {
            mediaAcertos = 10 * (idAcerto / idQuestao);
            notaFinal = Mathf.RoundToInt(mediaAcertos); // responsável por arredondar a nota para inteiro

            if (notaFinal > PlayerPrefs.GetInt("notaFinal" + idCategoria.ToString()))
            {
                PlayerPrefs.SetInt("notaFinal" + idCategoria.ToString(), notaFinal);
                PlayerPrefs.SetInt("acertos" + idCategoria.ToString(), (int)idAcerto);
            }

            PlayerPrefs.SetInt("notaFinalTemp" + idCategoria.ToString(), notaFinal);
            PlayerPrefs.SetInt("acertosTemp" + idCategoria.ToString(), (int)idAcerto);

            SceneManager.LoadScene("nota");
        }


    }
}
