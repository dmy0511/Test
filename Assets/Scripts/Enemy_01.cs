using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_01 : MonoBehaviour
{
    public Slider HpBar;

    private Player player;
    private Enemy_01 enemy_01;

    public Text scoretext;
    private int currentscore;
    private bool showQuestionMark = true;

    public float maxhp = 100;
    public float curhp = 100;

    void Start()
    {
        player = FindObjectOfType<Player>();
        enemy_01 = FindObjectOfType<Enemy_01>();

        HpBar.value = (float)curhp / (float)maxhp;

        currentscore = 0;
        UpdateScoreText();
    }

    void Update()
    {
        if (curhp <= 0)
        {
            ResetHealth();
            showQuestionMark = false;
            currentscore++;
            UpdateScoreText();
        }
        else
        {
            HpBar.value = curhp / maxhp;
        }
    }

    private void ResetHealth()
    {
        curhp = maxhp;
    }

    void UpdateScoreText()
    {
        if (showQuestionMark)
        {
            scoretext.text = "1 대 ? 의 전설";
        }
        else
        {
            scoretext.text = "1 대 " + currentscore.ToString() + " 의 전설";
        }
    }

    public void L_Attack(float amount)
    {
        player.curhp -= amount;
        curhp = Mathf.Clamp(curhp, 0, maxhp);
    }

    public void R_Attack(float amount)
    {
        player.curhp -= amount;
        curhp = Mathf.Clamp(curhp, 0, maxhp);
    }
}
