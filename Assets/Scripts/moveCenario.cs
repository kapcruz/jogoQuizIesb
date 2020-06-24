using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class moveCenario : MonoBehaviour
{

    public float bgSpeed;
    public Renderer bgRend;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // responsável por mover o cenário de acordo com a velocidade especificada em bgSpeed
        bgRend.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0f);
    }
}
