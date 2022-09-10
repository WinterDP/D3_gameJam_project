using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowCursor : MonoBehaviour
{
    //determina a aceitação da fuga da camera para o cursor
    [SerializeField] private float deadZone;
    
    //armazena informações do player na cena
    private GameObject player;
    //armazena informações da camera
    private Camera cam;
    //Vetor da posição da camera
    private Vector2 posCam;
    
    
    private void Awake() {
        player = GameObject.FindGameObjectWithTag("Player"); 
        cam = gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        cameraPosition();
    }

    //Calcula a posição da camera de acordo com a posição do mouse e do player
    void cameraPosition(){
        //posCam =  new Vector2(Input.mousePosition.x,Input.mousePosition.y) - get_viewport().size * 0.5
		//if _target.length() < Dead_Zone:
			//self.position = Vector2(0,0)
		//else:
			//self.position = _target.normalized() * (_target.length() -  Dead_Zone) * 0.5
    }
}
