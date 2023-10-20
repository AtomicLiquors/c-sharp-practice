using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake(){
        //
        //Debug.Log("플레이어 데이터가 준비되었습니다.");
    }
    
    void OnEnable(){
        // 오브젝트 활성화.
    }

    void Start(){
        // 업데이트 시작 직전, 최초 실행
        //Debug.Log("사냥 장비를 챙겼습니다.");
    }

    void FixedUpdate(){
        // 물리 연산 업데이트 : ""고정적으로 CPU 부하를 많이 사용""
        //Debug.Log("이동합니다.");
    }

    void Update(){
        // 게임 로직. 물리연산과 관련된 로직을 제외한 주기적 변동 로직. 60프레임으로 실행된다.

        // 키를 누르고 있음
        if(Input.anyKeyDown)
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        // 키를 누름
        if(Input.anyKey)
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");

        if(Input.GetKeyDown(KeyCode.Escape))
            Debug.Log("플레이어가 종료 커맨드를 입력했습니다.");

        if(Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽으로 이동 중");
        
        if(Input.GetKeyUp(KeyCode.LeftArrow))
            Debug.Log("왼쪽 이동을 멈췄습니다.");

         if(Input.GetMouseButtonDown(0))
            Debug.Log("발사!");

            
         if(Input.GetMouseButton(0))
            Debug.Log("Charging...");

            
         if(Input.GetMouseButtonUp(0))
            Debug.Log("차지샷!");
        
         if(Input.GetMouseButton(1))
            Debug.Log("Parring!");

    }

    void LateUpdate(){
        //Debug.Log("경험치 획득.");
    }

    void OnDisable(){

    }

    void OnDestroy(){
        //Debug.Log("플레이어 데이터를 해체했습니다.");
    }


}
