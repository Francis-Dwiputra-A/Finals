using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker_script : MonoBehaviour
{
    public Animator animator;
    public float maxHP = 5;
    public float HP;
    // Start is called before the first frame update
    void Start()
    {
        HP = maxHP;
    }

    public void btnAtt()
    {
        TakeHit(1);
        animator.SetTrigger("Attack");
    }
    public void TakeHit(float dmg)
    {
        HP -= dmg;
        if (HP < 0)
        {
            Destroy(GameObject.Find("Enemy"));
        }
    }
}
