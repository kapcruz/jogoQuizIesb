using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class comandos : MonoBehaviour
{

    public void carregaProximaCena(string nomeProximaCena)
    {
        SceneManager.LoadScene(nomeProximaCena);
    }

}
