using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuleetController : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // �e�e�̃X�s�[�h
    public bool isMovingRight = true; // ���[�U�[���E�Ɉړ����邩�ǂ���
    public float damage; // ���[�U�[�̃_���[�W�l
   

    void Start()
    {
       
    }

    void Update()
    {
        Vector2 position = transform.position;
        position.x += (isMovingRight ? speed : -speed) * Time.deltaTime;
        transform.position = position;

        
    }

    public void SetDirection(bool movingRight)
    {
        isMovingRight = movingRight;
    }
}
