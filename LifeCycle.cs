using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake(){
        //
        //Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }
    
    void OnEnable(){
        // ������Ʈ Ȱ��ȭ.
    }

    void Start(){
        // ������Ʈ ���� ����, ���� ����
        //Debug.Log("��� ��� ì����ϴ�.");
    }

    void FixedUpdate(){
        // ���� ���� ������Ʈ : ""���������� CPU ���ϸ� ���� ���""
        //Debug.Log("�̵��մϴ�.");
    }

    void Update(){
        // ���� ����. ��������� ���õ� ������ ������ �ֱ��� ���� ����. 60���������� ����ȴ�.

        // Ű�� ������ ����
        if(Input.anyKeyDown)
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");
        // Ű�� ����
        if(Input.anyKey)
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");

        if(Input.GetKeyDown(KeyCode.Escape))
            Debug.Log("�÷��̾ ���� Ŀ�ǵ带 �Է��߽��ϴ�.");

        if(Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("�������� �̵� ��");
        
        if(Input.GetKeyUp(KeyCode.LeftArrow))
            Debug.Log("���� �̵��� ������ϴ�.");

         if(Input.GetMouseButtonDown(0))
            Debug.Log("�߻�!");

            
         if(Input.GetMouseButton(0))
            Debug.Log("Charging...");

            
         if(Input.GetMouseButtonUp(0))
            Debug.Log("������!");
        
         if(Input.GetMouseButton(1))
            Debug.Log("Parring!");

    }

    void LateUpdate(){
        //Debug.Log("����ġ ȹ��.");
    }

    void OnDisable(){

    }

    void OnDestroy(){
        //Debug.Log("�÷��̾� �����͸� ��ü�߽��ϴ�.");
    }


}
