using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    //armazena o vetor com a posição do mouse
    private Vector2 mousePos;

    private void Awake() {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }
    private void FixedUpdate() {
        setMousePosition();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void setMousePosition(){
        //recebe as coordenadas do mouse na tela
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //coloca o sprite na posição do cursor
        transform.position = mousePos;
    }
}
