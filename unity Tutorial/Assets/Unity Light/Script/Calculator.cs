using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    int Add(int x, int y)
    {
        // �Ű� ������?
        // �Լ��� ���ǿ��� ���޹��� �μ��� �Լ� ���η� �����ϱ� ����
        // ����ϴ� �����Դϴ�.
        return x + y;
    }

    int Substract(int x, int y)
    {
        return x - y;
    }

    int Multiple(int x, int y)
    {
        return x * y;
    }

    int Divide(int x, int y)
    {
        return x / y;
    }
    // Start is called before the first frame update
    void Start()
    {
        //30
        Debug.Log (Add(10, 20));

    }

}