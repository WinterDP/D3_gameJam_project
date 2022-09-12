using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegDirection : MonoBehaviour
{
    //armazena o vetor que aponta para onde o 
    private Vector2 walkingDirection;
    //armazena o vetor da posição do player
    private Vector2 playerPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        legRotation();
    }

    public void legRotation(){
        //le a entrada do teclado wasd
        walkingDirection.x = Input.GetAxisRaw("Horizontal");
        walkingDirection.y = Input.GetAxisRaw("Vertical");

        playerPosition = new Vector2(transform.position.x, transform.position.y);

        float playerAngle = Mathf.Atan2(walkingDirection.y,walkingDirection.x)*Mathf.Rad2Deg - 90f;
        transform.rotation = Quaternion.Euler(Vector3.forward * playerAngle);

    }
}
