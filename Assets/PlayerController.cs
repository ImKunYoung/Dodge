using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public Rigidbody playerRigidBody; // 이동에 사용할 리지드바디 컴포넌트
    public float speead = 8f; // 이동 속력

    void Update() {
        // 위쪽 방향키 입력이 감지된 경우 z 방향 힘
        if (Input.GetKey(KeyCode.UpArrow) == true) {playerRigidBody,AddForce(0f, 0f, speed);}
        // 아래쪽 방향키 입력이 감지된 경우 -z 방향 힘
        if (Input.GetKey(KeyCode.DownArrow) == true) {playerRigidBody,AddForce(0f, 0f, -speed);}
        // 오른쪽 방향키 입력이 감지된 경우 x 방향 힘
        if (Input.GetKey(KeyCode.RightArrow) == true) {playerRigidBody,AddForce(speed, 0f, 0f);}
        // 왼쪽 방향키 입력이 감지된 경우 -x 방향 힘
        if (Input.GetKey(KeyCode.LeftArrow) == true) {playerRigidBody,AddForce(-speed, 0f, 0f);}
    }

    public void Die() {
        // 자신의 게임 오브젝트를 비활성화
        gameObject.SetActive(false);
    }
}
