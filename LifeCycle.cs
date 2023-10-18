using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake(){
        //
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }
    
    void OnEnable(){
        // ������Ʈ Ȱ��ȭ.
    }

    void Start(){
        // ������Ʈ ���� ����, ���� ����
        Debug.Log("��� ��� ì����ϴ�.");
    }

    void FixedUpdate(){
        // ���� ���� ������Ʈ : ""���������� CPU ���ϸ� ���� ���""
        Debug.Log("�̵��մϴ�.");
    }

    void Update(){
        // ���� ����. ��������� ���õ� ������ ������ �ֱ��� ���� ����. 60���������� ����ȴ�.
        Debug.Log("���� ���!");
    }

    void LateUpdate(){
        Debug.Log("����ġ ȹ��.");
    }

    void OnDisable(){

    }

    void OnDestroy(){
        Debug.Log("�÷��̾� �����͸� ��ü�߽��ϴ�.");
    }


}
