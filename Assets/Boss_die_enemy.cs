using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_die_enemy : MonoBehaviour
{
    public Animator animator;
    public float maxHP = 30;
    public float HP;
    public Healthbar healthbar;
    public Boss_die_knight knight;
    public Game_Load GL;
    Vector3 myVector;
    // Start is called before the first frame update
    void Start()
    {
        HP = maxHP;
        healthbar.setMaxHealth(HP);
        myVector = new Vector3(2.0f, 4.8f, 0.0f);
    }

    public void TakeHit(float dmg)
    {
        HP -= dmg;
        healthbar.setHealth(HP);
        if (HP < 1)
        {
            animator.SetTrigger("Die");
            Destroy(gameObject);
            GL.LoadMenu_Win();
        }
        else if (HP < 15)
        {
            animator.SetTrigger("Boss_counter_2");
            knight.TakeHit(5);
            DamagePopUp.Create(myVector, 5);
        }
        else
        {
            animator.SetTrigger("Boss_counter");
            knight.TakeHit(1);
            DamagePopUp.Create(myVector, 1);
        }
    }
}