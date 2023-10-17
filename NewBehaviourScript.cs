using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int health = 30;
    int level = 5;

    void Start()
    {
        Debug.Log("2kooong2");

        //float strength = 15.5f;
        string playerName = "2koooong2";
        bool isFullLevel = false;
        int exp = 1500;


        string[] monsters = {"슬라임", "사막뱀", "악마"};
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        List<string> items = new List<string>();
        items.Add("생명물약30");
        items.Add("생명물약10");

        int nextExp = 300 - ( exp % 300);
        Debug.Log(nextExp);

        string title = "Legendary";
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log(isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까? " + isEndTutorial);

       // int health = 30;
        int mana = 25;
        bool isBadCondition = health <= 50 || mana <= 20;

        string condition = isBadCondition ? "주의" : "정상";
        Debug.Log("현재 상태는: " + condition);

        if (condition == "주의") {
            Debug.Log("아이템을 사용하여 회복하세요.");
        }else{
            Debug.Log("");
        }

        if(isBadCondition && items[0] == "생명물약30"){
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션30을 사용했습니다.");
        }else if(isBadCondition && items[0] == "마나물약30"){
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션30을 사용하였습니다.");
        }

        switch (monsters[1]) {
            case "슬라임":
            case "사막뱀":
                Debug.Log("소형 몬스터 출현!");
                break;
            case "악마":
                Debug.Log("중형 몬스터 출현!");
                break;
            case "골렘":
                Debug.Log("대형 몬스터 출현!");
                break;
            default:
                Debug.Log("정체불명의 몬스터 출현!");
                break;
        }

        while(health > 0){
            health--;
            if(health > 0)
                Debug.Log("독 데미지를 입었습니다. " + health);
            else
                Debug.Log("사망했습니다.");

            if(health == 10){
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }

        for ( int count = 0; count < 10; count++) {
            health++;
            Debug.Log("응급 키트 사용..." + health);
        }

        for ( int index = 0; index < monsters.Length; index++) {
            Debug.Log("지역 내에 있는 몬스터 : " + monsters[index]);
        }

        foreach (string monster in monsters) {
            Debug.Log("지역 내에 있는 몬스터 : " + monster);
        }

        Heal();

        for(int index=0; index < monsters.Length; index++) {
            Debug.Log("용사는" + monsters[index] + "에게" + Battle(monsterLevel[index]));
        }

        Actor player = new Actor();
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;


    }

    void Heal () {
        health += 10;
        Debug.Log("힐을 받았습니다. " + health);
    }

    string Battle(int monsterLevel){
        string result;
        
        if(level >= monsterLevel)
            result="승리!";
        else
            result="패배";

        return result;
    }
}
