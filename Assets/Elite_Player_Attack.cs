using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elite_Player_Attack : MonoBehaviour
{
    public Animator animator;
    public float maxHP = 20;
    public float HP;
    public Healthbar healthbar;
    public EliteEnemyBehaviour enemyBehaviour;
    public Game_Load GL;
    Vector3 myVector;

    void Start()
    {
        HP = maxHP;
        healthbar.setMaxHealth(maxHP);
        myVector = new Vector3(14.0f, 4.8f, 0.0f);
    }

    public void btnAttack() {
        enemyBehaviour.takeHit(1);
        animator.SetTrigger("att");
        DamagePopUp.Create(myVector, 1);
    }

    public void btnStrike()
    {
        enemyBehaviour.takeHit(2);
        animator.SetTrigger("Strike");
        DamagePopUp.Create(myVector, 2);
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
            GL.LoadMenu();
        }
    }
}
