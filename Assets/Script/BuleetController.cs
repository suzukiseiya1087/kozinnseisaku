using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuleetController : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // 銃弾のスピード
    public bool isMovingRight = true; // レーザーが右に移動するかどうか
    public float damage; // レーザーのダメージ値
   

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
