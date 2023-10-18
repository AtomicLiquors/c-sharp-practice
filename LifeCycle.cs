using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake(){
        //
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }
    
    void OnEnable(){
        // 오브젝트 활성화.
    }

    void Start(){
        // 업데이트 시작 직전, 최초 실행
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    void FixedUpdate(){
        // 물리 연산 업데이트 : ""고정적으로 CPU 부하를 많이 사용""
        Debug.Log("이동합니다.");
    }

    void Update(){
        // 게임 로직. 물리연산과 관련된 로직을 제외한 주기적 변동 로직. 60프레임으로 실행된다.
        Debug.Log("몬스터 사냥!");
    }

    void LateUpdate(){
        Debug.Log("경험치 획득.");
    }

    void OnDisable(){

    }

    void OnDestroy(){
        Debug.Log("플레이어 데이터를 해체했습니다.");
    }


}
