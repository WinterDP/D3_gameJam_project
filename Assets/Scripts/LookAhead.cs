using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAhead : MonoBehaviour
{
        [SerializeField] private Transform playerTransform;
        [Range(2, 100)] [SerializeField] private float cameraTargetDivider;

        private Vector2 cameraTargetPosition;

        private Vector2 mousePosition;

        private Vector2 playerPosition;
 
        private void Update()
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            playerPosition = new Vector2(playerTransform.position.x,playerTransform.position.y);
            cameraTargetPosition = new Vector2((playerPosition.x + mousePosition.x) / 2, (playerPosition.y + mousePosition.y) / 2);
            cameraTargetPosition = new Vector2((playerPosition.x + cameraTargetPosition.x) / 2, (playerPosition.y + cameraTargetPosition.y) / 2);
            //var cameraTargetPosition = (mousePosition + (cameraTargetDivider - 1) * playerTransform.position) / cameraTargetDivider;
            transform.position = cameraTargetPosition;
        }

}
