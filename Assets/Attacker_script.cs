using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker_script : MonoBehaviour 
{
    public Animator animator;
    public float maxHP = 5;
    public float HP;
    public Die die;
    Vector3 myVector;
    // Start is called before the first frame update
    void Start()
    {
        HP = maxHP;
        myVector = new Vector3(14.0f, 4.8f, 0.0f);
    }

    public void btnAtt()
    {
        die.TakeHit(1);
        animator.SetTrigger("Attack");
        if(HP<0)
        {

        }
        else
        {
            DamagePopUp.Create(myVector,1);
        }
    }

    public void btnStrike()
    {
        die.TakeHit(2);
        animator.SetTrigger("Strike");
        if (HP < 0)
        {

        }
        else
        {
            DamagePopUp.Create(myVector, 2);
        }
    }
}
