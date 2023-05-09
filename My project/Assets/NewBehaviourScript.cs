using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int health = 30;
    int mana = 25;
    int level = 5;
    float strength = 15.5f;
    string title = "전설의";
    string playerName = "나검사";
    bool isFullLevel = false;
    int exp = 1500;
    

    void Start()
    {
        Debug.Log("Hello Unity!");

        // 1. 변수
        

        // 2. 그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        List<string> items = new List<string>();
        items.Add("생명물약 30");
        items.Add("마나물약 10");

        // 3. 연산자
        

        exp = 1500 + 320;                   // 1820
        exp = exp - 10;                     // 1810
        level = exp / 300;                  // 6
        strength = level * 3.1f;            // 18.6

        int nextExp = 300 - (exp % 300);    // 290

        
        Debug.Log(title + " " + playerName); // 전설의 용사

        int fulllevel = 99;
        isFullLevel = level == fulllevel;    // false

        bool isEndTutorial = level > 10;    // false

        
        
        bool isBadCondition = health <= 50 && mana <= 20;   // false
        bool isBadSituation = health <= 50 || mana <= 20;   // true

        string condition = isBadCondition ? "나쁨" : "좋음";    // 좋음

        // 4. 키워드 -> 자료형이나 내장함수와 같은 이름으로 변수 이름 지정 불가

        // 5. 조건문
        if (condition == "나쁨")
        {
            Debug.Log("플레이어 상태가 좋지 않습니다.");
        }
        else
        {
            Debug.Log("용사의 상태가 좋습니다.");
        };

        switch (monsters[0])
        {
            case"슬라임" :
                Debug.Log("소형 몬스터 출현");
                break;
            case "악마":
                Debug.Log("중형 몬스터 출현");
                break;
            case "골렘":
                Debug.Log("대형 몬스터 출현");
                break;
            default:
                Debug.Log("??? 몬스터가 출현");
                break;
        };

        // 6. 반복문
        while (health >0)
        {
            health--;
            if (health > 0)
            {
                Debug.Log("독 데미지를 입었습니다." + health);
            }
            else
            {
                Debug.Log("플레이어가 사망했습니다.");
            }

            if (health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        };

        for (int count = 0; count < 10; count++)
        {
            health++;
            Debug.Log("붕대로 치료 중" + health);
        }

        foreach(string monster in monsters)
        {
            Debug.Log("이 지역의 몬스터" + monster);
        }

        health = Heal(health);

        Healing();

        // 8. 클래스
        Player player = new Player();
        player.id = 0;
        player.name = "나법사";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은" + player.level + " 입니다.");
        Debug.Log(player.move());
    }

    // 7. 함수
    int Heal(int health)
    {
        health += 10;
        Debug.Log("힐을 받았습니다." + health);
        return health;
    }

    void Healing()
    {
        health += 15;
        Debug.Log("힐링을 받았습니다." + health);
    }
}
