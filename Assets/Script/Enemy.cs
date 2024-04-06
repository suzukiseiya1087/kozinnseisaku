using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.CompareTag("Bullet")) // 弾丸のタグを確認
    //    {

    //        Destroy(gameObject); // 敵オブジェクトを消去
    //    }
    //}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet")) // 弾丸のタグを確認
        {

            Destroy(gameObject); // 敵オブジェクトを消去
        }
    }
}
