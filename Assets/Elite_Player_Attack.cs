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

    void Start()
    {
        HP = maxHP;
        healthbar.setMaxHealth(maxHP);
    }

    public void btnAttack() {
        enemyBehaviour.takeHit(5);
        animator.SetTrigger("att");
    }

    public void btnStrike()
    {
        enemyBehaviour.takeHit(10);
        animator.SetTrigger("Strike");
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
