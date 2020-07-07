using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class notaFinal : MonoBehaviour
{

    private int idCategoria;

    public Text txtNota;
    public Text txtInfoCategoria;
    public Text txtInfoQuestao;

    public GameObject trofeu1;
    public GameObject trofeu2;
    public GameObject trofeu3;

    private int notaTotal;
    private int idAcerto;
    private int numerodeQuestoes;


    void Start()
    {
        idCategoria = PlayerPrefs.GetInt("idCategoria");
        notaTotal = PlayerPrefs.GetInt("notaFinalTemp"+idCategoria.ToString());
        idAcerto = PlayerPrefs.GetInt("acertosTemp"+idCategoria.ToString());
        numerodeQuestoes = PlayerPrefs.GetInt("numerodeQuestoes" + idCategoria.ToString());


        txtNota.text = notaTotal.ToString();
        txtInfoCategoria.text = "Voce acertou " + idAcerto.ToString() + " de  " + numerodeQuestoes.ToString() + " perguntas";


        if (notaTotal == 0)
        {
            trofeu1.SetActive(false);
            trofeu2.SetActive(false);
            trofeu3.SetActive(false);
        }
        if (notaTotal == 10)
        {
            trofeu1.SetActive(true);
            trofeu2.SetActive(true);
            trofeu3.SetActive(true);
        }
        if (notaTotal > 3 && notaTotal < 10)
        {
            trofeu1.SetActive(true);
            trofeu2.SetActive(true);
            trofeu3.SetActive(false);

        }

        if (notaTotal <= 3 && notaTotal > 0)
        {
            trofeu1.SetActive(true);
            trofeu2.SetActive(false);
            trofeu3.SetActive(false);
        }
    }

    public void repetirJogar()
    {
        SceneManager.LoadScene("categoria" + idCategoria.ToString());
    }
}
