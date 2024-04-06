using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject bulletPrefab; // 弾のプレハブ
    public Transform bulletSpawnPoint; // 弾を生成する位置

    public float bulletSpeed = 10f; // 弾の速さ

    void Update()
    {
        // スペースキーが押されたら
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 弾を生成して右方向に飛ばす
            Shoot();
        }
    }

    void Shoot()
    {
        // 弾を生成してbulletPrefabに設定
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);

        // 弾を右方向に飛ばす
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * bulletSpeed;

        // 弾が画面外にいったら自動的に破棄する
        DestroyOutOfBounds(bullet);
    }

    void DestroyOutOfBounds(GameObject bullet)
    {
        // カメラの左下と右上のワールド座標を取得
        Vector3 bottomLeft = Camera.main.ScreenToWorldPoint(Vector3.zero);
        Vector3 topRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        // 弾が画面外にいるかどうかをチェックして破棄する
        if (bullet.transform.position.x < bottomLeft.x || bullet.transform.position.x > topRight.x ||
            bullet.transform.position.y < bottomLeft.y || bullet.transform.position.y > topRight.y)
        {
            Destroy(bullet);
        }
    }
}



