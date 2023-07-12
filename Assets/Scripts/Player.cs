using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Slider HpBar;

    private Player player;
    private Enemy_01 enemy_01;

    public float maxhp = 100;
    public float curhp = 100;

    void Start()
    {
        player = FindObjectOfType<Player>();
        enemy_01 = FindObjectOfType<Enemy_01>();

        HpBar.value = (float)curhp / (float)maxhp;
    }

    void Update()
    {
        HandleHp();
    }

    private void HandleHp()
    {
        HpBar.value = (float)curhp / (float)maxhp;
    }

    public void L_Attack(float amount)
    {
        enemy_01.curhp -= amount;
        curhp = Mathf.Clamp(curhp, 0, maxhp);
    }

    public void R_Attack(float amount)
    {
        player.curhp -= amount;
        curhp = Mathf.Clamp(curhp, 0, maxhp);
    }
}
