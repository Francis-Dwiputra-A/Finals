using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Easy_die_knight : MonoBehaviour
{
    public Animator animator;
    public float maxHP = 20;
    public float HP;
    public Healthbar healthbar;
    public Game_Load GL;
    // Start is called before the first frame update
    void Start()
    {
        HP = maxHP;
        healthbar.setMaxHealth(HP);
    }

    public void TakeHit(float dmg)
    {
        HP -= dmg;
        healthbar.setHealth(HP);
        if (HP < 1)
        {
            animator.SetTrigger("Ez_Die");
            Destroy(gameObject);
            GL.LoadMenu_Lose();
        }
    }
}
