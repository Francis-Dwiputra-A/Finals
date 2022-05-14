using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public Animator animator;
    public float maxHP = 5;
    public float HP;
    public Healthbar healthbar;
    // Start is called before the first frame update
    public Game_Load GL;
    void Start()
    {
        HP = maxHP;
        healthbar.setMaxHealth(maxHP);
    }

    public void TakeHit(float dmg)
    {
        HP -= dmg;
        healthbar.setHealth(HP);
        if (HP < 1)
        {
            animator.SetTrigger("Die");
            Destroy(gameObject);
            GL.LoadNextLevel();
        }
    }
}
