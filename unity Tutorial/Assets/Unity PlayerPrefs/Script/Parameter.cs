using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parameter : MonoBehaviour
{
    private int attack = 10;

    // Start is called before the first frame update
    void Start()
    {
        #region �μ�
        // �Լ��� ȣ��� �� �Ű������� ������ �����ϴ� ���Դϴ�.
        Debug.Log("attack�� �� : " + attack);
        Damage(attack);
        Debug.Log("attack�� �� : " + attack);


        #endregion
    }

    #region �Ű�����
    // �Լ��� ���ǿ��� ���޹��� �μ��� �Լ� ���η�
    // �����ϱ� ���� ����ϴ� �����Դϴ�.
    void Damage(int damage)
    {
        damage = 100;
    }

    #endregion
}
