using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //objeto para referenciar os atributos do personagem criados no ScriptableObject
    [SerializeField] private PlayerAttributes playerAttributes;
    //referencia a camera da cena
    [SerializeField] Camera camera;

    //Armazena o Rigidbody do objeto
    private Rigidbody2D rigidBody;
    

    //armazena a direção em que o jogador direciona o controle
    private Vector2 movement;
    //armazena o vetor calculado da posição do mouse
    private Vector2 mousePos;

    //checks para animação
    private bool isWalking = false;
    
    
    private void Awake() {
        //pega o rigidbody do objeto
        rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        checkPlayerMovement();
    }

    private void FixedUpdate() {
        movePlayer();
    }

    private void checkPlayerMovement(){
        //Le a entrada do teclado
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if((movement.x != 0) || (movement.y != 0)){
            isWalking = true;
        }else{
            isWalking = false;
        }
        

        //Le a posição do mouse usando a camera
        mousePos = camera.ScreenToWorldPoint(Input.mousePosition);
    }

    private void movePlayer(){
        //altera a posição do rigidBody para a posição calculada entre a posição atual e a desejada pelo input do player
        rigidBody.MovePosition(rigidBody.position + (movement * playerAttributes.playerSpeed * Time.fixedDeltaTime));

        
    
        //calcula a rotação do Player de acordo com a posição atual e a desejada
        Vector2 lookDir = mousePos - rigidBody.position;
        float playerAngle = Mathf.Atan2(lookDir.y,lookDir.x)*Mathf.Rad2Deg - 90f;
        rigidBody.rotation = playerAngle;
    }
}
