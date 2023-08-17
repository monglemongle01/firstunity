using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NewObject : MonoBehaviour
{
    int[]array = new int[3];    

    #region 예외 처리
    private void Awake()
    {
        try
        {
            for (int i = 0; i < 5; i++)
            {
                array[i] = i;
            }
        }
        catch(Exception error) 
        {
            Debug.Log(error);
        }
    }

    #endregion

    #region 박싱과 언박싱
    // 박싱은 값 타입을 참조 타입을 변환하는 과정을 의미하며,
    // 언박싱 참조 타입을 값 타입으로 변환하는 과정을 의미합니다.

    // Start is called before the first frame update
    void Start()
    {
        int data = 10;

        // 참조 변수 <- 값 타입 변수
        object obj = data;

        // 값 타입 <- 참조 타입 변수
        int result = (int)obj;


    }

    #endregion
}
