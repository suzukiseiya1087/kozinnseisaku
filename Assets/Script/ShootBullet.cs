using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject bulletPrefab; // �e�̃v���n�u
    public Transform bulletSpawnPoint; // �e�𐶐�����ʒu

    public float bulletSpeed = 10f; // �e�̑���

    void Update()
    {
        // �X�y�[�X�L�[�������ꂽ��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // �e�𐶐����ĉE�����ɔ�΂�
            Shoot();
        }
    }

    void Shoot()
    {
        // �e�𐶐�����bulletPrefab�ɐݒ�
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);

        // �e���E�����ɔ�΂�
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * bulletSpeed;

        // �e����ʊO�ɂ������玩���I�ɔj������
        DestroyOutOfBounds(bullet);
    }

    void DestroyOutOfBounds(GameObject bullet)
    {
        // �J�����̍����ƉE��̃��[���h���W���擾
        Vector3 bottomLeft = Camera.main.ScreenToWorldPoint(Vector3.zero);
        Vector3 topRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        // �e����ʊO�ɂ��邩�ǂ������`�F�b�N���Ĕj������
        if (bullet.transform.position.x < bottomLeft.x || bullet.transform.position.x > topRight.x ||
            bullet.transform.position.y < bottomLeft.y || bullet.transform.position.y > topRight.y)
        {
            Destroy(bullet);
        }
    }
}



