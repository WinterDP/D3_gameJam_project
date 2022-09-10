using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotationEffect : MonoBehaviour
{   
    //Armazena o valor a ser rotado pela camera
    [SerializeField] private float camRotation;

    //Armazena o controle do player na cena
    private PlayerController playerController;


    // Start is called before the first frame update
    private void Awake()
    {
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    private void Update()
    {
        //playerController.movement
    }
    
    
}
