using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elite_Player_Attack : MonoBehaviour
{
    public Animator animator;
    public float maxHP = 40;
    public float HP;
    public Healthbar healthbar;
    public EliteEnemyBehaviour enemyBehaviour;
    Vector3 myVector;

    void Start()
    {
        HP = maxHP;
        healthbar.setMaxHealth(maxHP);
        myVector = new Vector3(14.0f, 4.8f, 0.0f);
    }

    public void btnAttack() {
        enemyBehaviour.takeHit(5);
        animator.SetTrigger("att");
        if (HP < 0)
        {

        }
        else
        {
            DamagePopUp.Create(myVector, 5);
        }
    }

    public void btnStrike()
    {
        enemyBehaviour.takeHit(10);
        animator.SetTrigger("Strike");
        if (HP < 0)
        {

        }
        else
        {
            DamagePopUp.Create(myVector, 10);
        }
    }

    public void btnShield() {
        animator.SetTrigger("Elite Defend");
    }

    public void TakeHit(float dmg)
    {
        HP -= dmg;
        healthbar.setHealth(HP);
        if (HP < 1)
        {
            Destroy(gameObject);
        }
    }
}
