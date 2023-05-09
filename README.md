# UnityGamePractice
- 유니티로 게임 만들기 기초부터 시작\
- 공부 자료
  - Youtube : "골드메탈"
  - 해당 유튜브 주소 : "https://www.youtube.com/@goldmetal"
  - 재생목록 : "https://www.youtube.com/playlist?list=PLO-mt5Iu5TeYI4dbYwWP8JqZMC9iuUIW2"
---
## 2023년 05월 09일
---
### 당일 공부 영상
- https://youtu.be/lYzGTUJxPDQ
- https://youtu.be/Xtfz4jPaUI0
- https://youtu.be/1QyynHJ-3Ec
- https://youtu.be/j6XLEqgq-dE

---
### Unity 기본 조작 관련
1. Unity 게임 설치 및 작동법 숙지(기존에 알고 있었으나 다른 공부로 까먹어서 remind)
2. C# script 열기
   1. unity Project 창에서 Asset 폴더
   2. 마우스 좌클릭 create -> C# Script
3. Console 창 열기
4. Visual Studio로 원하는 코드 작성
5. Code를 실행하고자 하는 Object의 Inspector 창에 드래그

### C# 기본 문법(cs 파일 참조)
1. 자료형: int, float, string, bool이 자주 쓰임
2. Python의 print, C의 printf, C++의 cout 같은 출력함수는 Debug.Log()이다.
3. 그룹형 변수의 경우(ex. string) "string[] 변수명 = { 변수들 }"의 형태를 가진다.
4. 변수의 값을 비워둔 상태로 크기만 해당하는 배열을 만들기 위해서는 new를 통해 크기만 생성
5. List: 기능이 추가된 가변형 그룹형 변수\
  List<> 변수명 = new List<>(); -> <>안에는 자료형\
  변수명.Add("")하면 추가됨\
  변수명.RemoveAt(index)하면 해당 인덱스 값 삭제
6. 연산자
  사칙 연산 가능(+, -, *, /)
  나머지(%)는 있으나 python의 몫(//)은 존재하지 않음
  문자열(string)도 '+' 가능
7. 비교연산자\
  다른 언어와 동일('==', '>', '<', '<=', '>=')\
  &&연산자 -> 둘 다 true이면 true 반환\
  ||연산자 -> 둘 중 하나라도 true이면 true 반환\
  삼항 연산자 -> true이면 : 앞의 값 false이면 : 뒤의 값 출력
8. 키워드
9. 조건문
   1.  if문 -> C++과 동일 
   2.  switch case문
10. 반복문
    1.  while문
    2.  for문
    3.  foreach문
11. 함수
    1.  자료형으로 할 시 반환 데이터가 있는 함수 타입(int 등)
    2.  void 함수 : 반환 데이터가 없는 함수 타입
        1.  지역변수 : 함수 안에 선언된 변수
        2.  전역변수 : 함수 바깥에 선언된 변수
12. 클래스
    1.  다른 파일에 정의된 변수 및 함수들을 끌어오는 행위
    2.  해당 파일 안에 다른 파일을 부모와 자식 클래스로 상속 가능


### 당일 생긴 오류
1. C#의 경우 따옴표('')와 쌍따옴표("")의 구분이 필수적이었다.\
  따옴표의 경우 단 하나의 글자만 품을 수 있으며 그 이상일 경우 반드시 쌍따옴표를 사용해야 했다.
2. Only assignment, call, increment, decrement, await, and new object expressions can be used as a statement\
Healing 함수를 Healing();로 표현하지 않고 Healing만 적었다가 생긴 오류
---