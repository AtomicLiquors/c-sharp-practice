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


        string[] monsters = {"������", "�縷��", "�Ǹ�"};
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);

        List<string> items = new List<string>();
        items.Add("������30");
        items.Add("������10");

        int nextExp = 300 - ( exp % 300);
        Debug.Log(nextExp);

        string title = "Legendary";
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        Debug.Log(isFullLevel);

        bool isEndTutorial = level > 10;
        Debug.Log("Ʃ�丮���� ���� ����Դϱ�? " + isEndTutorial);

       // int health = 30;
        int mana = 25;
        bool isBadCondition = health <= 50 || mana <= 20;

        string condition = isBadCondition ? "����" : "����";
        Debug.Log("���� ���´�: " + condition);

        if (condition == "����") {
            Debug.Log("�������� ����Ͽ� ȸ���ϼ���.");
        }else{
            Debug.Log("");
        }

        if(isBadCondition && items[0] == "������30"){
            items.RemoveAt(0);
            health += 30;
            Debug.Log("��������30�� ����߽��ϴ�.");
        }else if(isBadCondition && items[0] == "��������30"){
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("��������30�� ����Ͽ����ϴ�.");
        }

        switch (monsters[1]) {
            case "������":
            case "�縷��":
                Debug.Log("���� ���� ����!");
                break;
            case "�Ǹ�":
                Debug.Log("���� ���� ����!");
                break;
            case "��":
                Debug.Log("���� ���� ����!");
                break;
            default:
                Debug.Log("��ü�Ҹ��� ���� ����!");
                break;
        }

        while(health > 0){
            health--;
            if(health > 0)
                Debug.Log("�� �������� �Ծ����ϴ�. " + health);
            else
                Debug.Log("����߽��ϴ�.");

            if(health == 10){
                Debug.Log("�ص����� ����մϴ�.");
                break;
            }
        }

        for ( int count = 0; count < 10; count++) {
            health++;
            Debug.Log("���� ŰƮ ���..." + health);
        }

        for ( int index = 0; index < monsters.Length; index++) {
            Debug.Log("���� ���� �ִ� ���� : " + monsters[index]);
        }

        foreach (string monster in monsters) {
            Debug.Log("���� ���� �ִ� ���� : " + monster);
        }

        Heal();

        for(int index=0; index < monsters.Length; index++) {
            Debug.Log("����" + monsters[index] + "����" + Battle(monsterLevel[index]));
        }

        Actor player = new Actor();
        player.id = 0;
        player.name = "������";
        player.title = "������";
        player.strength = 2.4f;


    }

    void Heal () {
        health += 10;
        Debug.Log("���� �޾ҽ��ϴ�. " + health);
    }

    string Battle(int monsterLevel){
        string result;
        
        if(level >= monsterLevel)
            result="�¸�!";
        else
            result="�й�";

        return result;
    }
}
