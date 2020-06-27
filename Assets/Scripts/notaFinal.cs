using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class notaFinal : MonoBehaviour
{

    private int idCategoria;

    public Text txtNota;
    public Text txtInfoCategoria;

    public GameObject trofeu1;
    public GameObject trofeu2;
    public GameObject trofeu3;

    private int notaTotal;
    private int idAcerto;


    void Start()
    {
        idCategoria = PlayerPrefs.GetInt("idCategoria");
        notaTotal = PlayerPrefs.GetInt("notaFinalTemp"+idCategoria.ToString());
        idAcerto = PlayerPrefs.GetInt("acertosTemp" + idCategoria.ToString());


        txtNota.text = notaTotal.ToString();
        txtInfoCategoria.text = "Voce acertou " + idAcerto.ToString() + " de 10 perguntas";
    }
}
