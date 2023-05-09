using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int health = 30;
    int mana = 25;
    int level = 5;
    float strength = 15.5f;
    string title = "������";
    string playerName = "���˻�";
    bool isFullLevel = false;
    int exp = 1500;
    

    void Start()
    {
        Debug.Log("Hello Unity!");

        // 1. ����
        

        // 2. �׷��� ����
        string[] monsters = { "������", "�縷��", "�Ǹ�" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        List<string> items = new List<string>();
        items.Add("������ 30");
        items.Add("�������� 10");

        // 3. ������
        

        exp = 1500 + 320;                   // 1820
        exp = exp - 10;                     // 1810
        level = exp / 300;                  // 6
        strength = level * 3.1f;            // 18.6

        int nextExp = 300 - (exp % 300);    // 290

        
        Debug.Log(title + " " + playerName); // ������ ���

        int fulllevel = 99;
        isFullLevel = level == fulllevel;    // false

        bool isEndTutorial = level > 10;    // false

        
        
        bool isBadCondition = health <= 50 && mana <= 20;   // false
        bool isBadSituation = health <= 50 || mana <= 20;   // true

        string condition = isBadCondition ? "����" : "����";    // ����

        // 4. Ű���� -> �ڷ����̳� �����Լ��� ���� �̸����� ���� �̸� ���� �Ұ�

        // 5. ���ǹ�
        if (condition == "����")
        {
            Debug.Log("�÷��̾� ���°� ���� �ʽ��ϴ�.");
        }
        else
        {
            Debug.Log("����� ���°� �����ϴ�.");
        };

        switch (monsters[0])
        {
            case"������" :
                Debug.Log("���� ���� ����");
                break;
            case "�Ǹ�":
                Debug.Log("���� ���� ����");
                break;
            case "��":
                Debug.Log("���� ���� ����");
                break;
            default:
                Debug.Log("??? ���Ͱ� ����");
                break;
        };

        // 6. �ݺ���
        while (health >0)
        {
            health--;
            if (health > 0)
            {
                Debug.Log("�� �������� �Ծ����ϴ�." + health);
            }
            else
            {
                Debug.Log("�÷��̾ ����߽��ϴ�.");
            }

            if (health == 10)
            {
                Debug.Log("�ص����� ����մϴ�.");
                break;
            }
        };

        for (int count = 0; count < 10; count++)
        {
            health++;
            Debug.Log("�ش�� ġ�� ��" + health);
        }

        foreach(string monster in monsters)
        {
            Debug.Log("�� ������ ����" + monster);
        }

        health = Heal(health);

        Healing();

        // 8. Ŭ����
        Player player = new Player();
        player.id = 0;
        player.name = "������";
        player.title = "������";
        player.strength = 2.4f;
        player.weapon = "������";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "�� ������" + player.level + " �Դϴ�.");
        Debug.Log(player.move());
    }

    // 7. �Լ�
    int Heal(int health)
    {
        health += 10;
        Debug.Log("���� �޾ҽ��ϴ�." + health);
        return health;
    }

    void Healing()
    {
        health += 15;
        Debug.Log("������ �޾ҽ��ϴ�." + health);
    }
}
