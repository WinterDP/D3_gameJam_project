using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "PlayerAttributes", menuName = "D3_gameJam_project/PlayerAttributes", order = 0)]
public class PlayerAttributes : ScriptableObject {
    [SerializeField] private float playerSpeed;

    public float getPlayerSpeed(){
        return playerSpeed;
    }
}

