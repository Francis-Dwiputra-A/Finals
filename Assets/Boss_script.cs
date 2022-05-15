using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_script : MonoBehaviour
{
    public Animator animator;
    public Boss_die_enemy enemy_die;
    public Boss_die_knight knight_die;
    Vector3 myVector;
    // Start is called before the first frame update
    void Start()
    {
        myVector = new Vector3(14f, 4.8f, 0.0f);
    }

    public void btnAtt()
    {
        enemy_die.TakeHit(2);
        animator.SetTrigger("Boss_att");
        DamagePopUp.Create(myVector, 2);
    }

    public void btnDef()
    {
        enemy_die.TakeHit(0);
        animator.SetTrigger("Boss_def");
    }

    public void btnStrike()
    {
        enemy_die.TakeHit(4);
        animator.SetTrigger("Boss_strike");
        DamagePopUp.Create(myVector, 4);
    }
}
