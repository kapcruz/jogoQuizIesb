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

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
