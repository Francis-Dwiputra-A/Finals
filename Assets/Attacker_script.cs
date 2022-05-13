using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker_script : MonoBehaviour 
{
    public Animator animator;
    public float maxHP = 5;
    public float HP;
    public Die die;
    // Start is called before the first frame update
    void Start()
    {
        HP = maxHP;
    }

    public void btnAtt()
    {
        die.TakeHit(1);
        animator.SetTrigger("Attack");
    }

    public void btnStrike()
    {
        die.TakeHit(2); 
        animator.SetTrigger("Strike");
    }
}
