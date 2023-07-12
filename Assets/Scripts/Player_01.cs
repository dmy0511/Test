using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_01 : MonoBehaviour
{
    public Animator animator; // 애니메이터
    
    void Start()
    {
        animator = GetComponent<Animator>(); // 애니메이터 컴포넌트 가져오기
    }

    void Update()
    {
        
    }
}
