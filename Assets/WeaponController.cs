using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WeaponController : MonoBehaviour
{
    [SerializeField] private GameObject weaponPrefab;

    //aramzena o Scriptable Object da arma que o player está segurando
    [SerializeField] private WeaponAtributtes weaponAtributtes;

    //Ponto de onde a arma vai ser disparada
    [SerializeField] private Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if(weaponPrefab != null)
                throwWeapon();
        }
    }

    void throwWeapon(){

        GameObject weapon = Instantiate(weaponPrefab,firePoint.position,firePoint.rotation);
        Rigidbody2D weaponRb = weapon.GetComponent<Rigidbody2D>();
        weaponRb.AddForce(firePoint.up * weaponAtributtes.getWeaponSpeed(), ForceMode2D.Impulse);

        weaponPrefab = null;

    }

        
}
