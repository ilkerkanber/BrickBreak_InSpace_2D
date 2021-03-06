using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRotater
{
    public void RotateWeapon(GameObject weapon,float angleValue)
    {
        angleValue = Mathf.Clamp(angleValue, 30, 140);
        weapon.transform.rotation = Quaternion.Euler(0, 0, angleValue);
    }
    public void Shout(GameObject bullet, GameObject direction, float speed)
    {
       bullet.GetComponent<Rigidbody2D>().AddForce(direction.transform.right * speed * 10);
    }
}