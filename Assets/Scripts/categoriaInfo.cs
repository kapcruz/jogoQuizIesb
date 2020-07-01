using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class categoriaInfo : MonoBehaviour
{

    public int idCategoria;
    public GameObject trofeu1;
    public GameObject trofeu2;
    public GameObject trofeu3;
    private int notaFinal;

    // Start is called before the first frame update
    void Start()
    {
        trofeu1.SetActive(false);
        trofeu2.SetActive(false);
        trofeu3.SetActive(false);

        notaFinal = PlayerPrefs.GetInt("notaFinalTemp" + idCategoria.ToString());


        if (notaFinal == 0)
        {
            trofeu1.SetActive(false);
            trofeu2.SetActive(false);
            trofeu3.SetActive(false);
        }
        if (notaFinal == 10)
        {
            trofeu1.SetActive(true);
            trofeu2.SetActive(true);
            trofeu3.SetActive(true);
        }
        if (notaFinal > 3 && notaFinal < 10)
        {
            trofeu1.SetActive(true);
            trofeu2.SetActive(true);
            trofeu3.SetActive(false);

        }

        if (notaFinal <= 3 && notaFinal > 0)
        {
            trofeu1.SetActive(true);
            trofeu2.SetActive(false);
            trofeu3.SetActive(false);
        }

    }
}
