using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum enumWeaponType
{
    BOTTLE, PISTOL, SHOTGUN, RIFLE
}

[CreateAssetMenu(fileName = "WeaponAtributtes", menuName = "D3_gameJam_project/WeaponAtributtes", order = 0)]
public class WeaponAtributtes : ScriptableObject {
    [SerializeField] private Sprite weaponSprite;
    
    [SerializeField] private float weaponSpeed;

    [SerializeField] private enumWeaponType weaponType;


    public Sprite getWeaponSprite(){
        return weaponSprite;
    }

    public float getWeaponSpeed(){
        return weaponSpeed;
    }

    public enumWeaponType getWeaponType(){
        return weaponType;
    }

}
