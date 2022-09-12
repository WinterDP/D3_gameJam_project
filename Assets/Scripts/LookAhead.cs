using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAhead : MonoBehaviour
{
        //recebe o transfor do player
        [SerializeField] private Transform playerTransform;

        // armazena o valor a ser passado para a nova posição do projeto objeto
        private Vector2 cameraTargetPosition;

        private Vector2 mousePosition;

        private Vector2 playerPosition;
 
        private void Update()
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            playerPosition = new Vector2(playerTransform.position.x,playerTransform.position.y);

            //calcula a posição do objeto a ser seguido pela camera através da equação de ponto médio
            cameraTargetPosition = new Vector2((playerPosition.x + mousePosition.x) / 2, (playerPosition.y + mousePosition.y) / 2);
            cameraTargetPosition = new Vector2((playerPosition.x + cameraTargetPosition.x) / 2, (playerPosition.y + cameraTargetPosition.y) / 2);
            
            //var cameraTargetPosition = (mousePosition + (cameraTargetDivider - 1) * playerTransform.position) / cameraTargetDivider;
            transform.position = cameraTargetPosition;
        }

}
