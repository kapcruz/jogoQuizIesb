using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class temaCategoria : MonoBehaviour
{

    public Button botaoplay;
    public Text nome_categoria;
    public Text infoRecorde;

    public GameObject infoCategoria;

    public string[] nomeTema;

    public int numeroQuestoes;
    public int idCategoria;


    // Start is called before the first frame update
    void Start()
    {
        //inicia o nome do tema como 0 para mensagem padrao
        idCategoria = 0;
        //Seta p texto que estiver no elemento 0
        nome_categoria.text = nomeTema[idCategoria];
        //Info recorde como vazio
        infoRecorde.text = "Recorde: ";
        //esconde elementos
        infoCategoria.SetActive(false);

        botaoplay.interactable = false;

    }

    // Update is called once per frame
    public void selecionaCategoria(int index)
    {
        idCategoria = index;
        //Grava o id da categoria
        PlayerPrefs.SetInt("idCategoria", idCategoria);
        nome_categoria.text = nomeTema[index];
        int acertos = PlayerPrefs.GetInt("acertosTemp" + idCategoria.ToString());

        infoRecorde.text = "Recorde: Você acertou  " + acertos.ToString() + " de " + numeroQuestoes.ToString() +" ";
        infoCategoria.SetActive(true);
        botaoplay.interactable = true;

    }

    // Update is called once per frame
    public void carregaCategoriaJogar()
    {

        SceneManager.LoadScene("categoria"+idCategoria.ToString());

    }

}
