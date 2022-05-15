using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easy_script : MonoBehaviour
{
    public Animator animator;
    public float maxHP = 10;
    public float HP;
    public Easy_die_enemy enemy_die;
    public Easy_die_knight knight_die;
    Vector3 myVector;
    // Start is called before the first frame update
    void Start()
    {
        HP = maxHP;
        myVector = new Vector3(14f, 4.8f, 0.0f);
    }

    public void btnAtt()
    {
        enemy_die.TakeHit(1);
        animator.SetTrigger("Ez_att");
        if (HP < 0)
        {

        }
        else
        {
            DamagePopUp.Create(myVector, 1);
        }
    }

    public void btnDef()
    {
        animator.SetTrigger("Ez_def");
        animator.SetTrigger("Ez_counter");
    }

    public void btnStrike()
    {
        enemy_die.TakeHit(2);
        animator.SetTrigger("Ez_strike");
        if (HP < 0)
        {

        }
        else
        {
            DamagePopUp.Create(myVector, 2);
        }
    }
}
