using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public Rigidbody playerRigidBody; // �̵��� ����� ������ٵ� ������Ʈ
    public float speead = 8f; // �̵� �ӷ�

    void Update() {
        // ���� ����Ű �Է��� ������ ��� z ���� ��
        if (Input.GetKey(KeyCode.UpArrow) == true) {playerRigidBody,AddForce(0f, 0f, speed);}
        // �Ʒ��� ����Ű �Է��� ������ ��� -z ���� ��
        if (Input.GetKey(KeyCode.DownArrow) == true) {playerRigidBody,AddForce(0f, 0f, -speed);}
        // ������ ����Ű �Է��� ������ ��� x ���� ��
        if (Input.GetKey(KeyCode.RightArrow) == true) {playerRigidBody,AddForce(speed, 0f, 0f);}
        // ���� ����Ű �Է��� ������ ��� -x ���� ��
        if (Input.GetKey(KeyCode.LeftArrow) == true) {playerRigidBody,AddForce(-speed, 0f, 0f);}
    }

    public void Die() {
        // �ڽ��� ���� ������Ʈ�� ��Ȱ��ȭ
        gameObject.SetActive(false);
    }
}
