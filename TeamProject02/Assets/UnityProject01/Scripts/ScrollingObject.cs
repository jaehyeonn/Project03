using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public float speed = 10f; //�̵��ӵ�
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //�ʴ� ���ǵ��� �ӵ��� �������� �����̵�
        if (GameManager.instance.isGameover == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
