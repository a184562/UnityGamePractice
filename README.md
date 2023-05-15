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


### 오늘의 오류
1. C#의 경우 따옴표('')와 쌍따옴표("")의 구분이 필수적이었다.\
  따옴표의 경우 단 하나의 글자만 품을 수 있으며 그 이상일 경우 반드시 쌍따옴표를 사용해야 했다.
2. Only assignment, call, increment, decrement, await, and new object expressions can be used as a statement\
Healing 함수를 Healing();로 표현하지 않고 Healing만 적었다가 생긴 오류
---
## 2023년 05월 10일
---
### 당일 공부 영상
- https://youtu.be/PyN3JkPTpAI
- https://youtu.be/wqRwsW03JR4


---
### 유니티 게임오브젝트 흐름
1. 초기화
  - Awake 함수(void Awake()) : 게임 오브젝트 생성 시, 최초 실행
  - Start 함수(void Start()) : 업데이트 시작 직전, 최초 실행
2. 물리 연산
  - FixedUpdate 함수(void FixedUpdate()) : 물리 연산 업데이트
    - 고정된 실행 주기로 CPU를 많이 사용
    - 1초에 약 50회 호출(50프레임)
3. 게임 로직
  - Update 함수(void Update()) : 게임 로직 업데이트
    - 사용자 컴퓨터에 따라 실행 횟수가 달라짐
    - 60 프레임 정도
  - LateUpdate 함수(void LateUpdate()) : 모든 업데이트가 끝난 후 업데이트
    - 보통 캐릭터를 따라가는 카메라나 후처리가 들어감
4. 해체
   - OnDestry 함수(void OnDestry()) : 게임 오브젝트가 삭제될 때
5. 활성화(초기화와 물리영역 사이[Awake와 Start 사이])
   - OnEnable 함수(void OnEnable()) : 게임 오브젝트가 활성화 되었을 때
6. 비활성화(게임로직과 해체 사이[Update 함수들과 OnDestroy 사이])
   - OnDisable 함수(void OnDisable()) : 게임 오브젝트가 비활성화 되었을 때

### 키보드 마우스 작동
1. Unity 기본 제공 class 
   - Input
     - 입력함수는 3가지 행동 구분
       - Down : 누를 때
       - Stay : 누르고 있을 때(따로 작성 X)
       - Up : 눌렀다가 뗄 때
       - 최초의 anyKey만 Down과 일반 anyKey를 구분하고 이후로는 Stay 상태만 작성
     - Input.anyKeyDown : 아무 입력을 최초로 받을 때 true
     - Input.anyKey : 입력을 받고 있는 동안(키를 누르고 있는동안 true)
     - Input.GetKeyUP(KeyCode.{key}) : {key} 키보드 입력을 받으면 true
       - Enter는 Return
       - ESC는 Escape
     - Input.GetMouseButton(num) : 마우스로 클릭할 때
       - 0 : 마우스 왼쪽 버튼 
       - 1 : 마우스 오른쪽 버튼
       - Stay 상태로 기를 모으고 Up으로 쏘는 메가맨 장전 슈팅 느낌 가능(GetKey로도 가능)
     - Button
       - Unity - Edit - Project Settings에서 Input Manager로 버튼 추가 가능
       - Axes를 열고 조작
         - Size : 버튼의 개수(기본값 18)
           - Horizontal : 수평 - 좌, 우, a, d
             - Gravity, Dead, Sensitivity는 잘 안건드림
           - Vertical : 수직 - 상, 하, w, s
         - GetButton : Input 버튼 입력을 받으면 true
           - Input.GetButton("Axe 내 버튼 이름을 문자열로")
         - Size 숫자를 바꿔주면 기능 개수를 조절 가능
       - GetAxis : 수평, 수직 입력을 받으면 float로 받음
       - GetAxisRaw : 값은 -1, 0, 1만 있음

2. 오브젝트 이동
   - 오브젝트의 위치는 Transform에서 지정
   - Transform을 따로 선언해줄 필요는 없음
     - 오브젝트는 변수 tansform을 항상 가지고 있음
   - transform.Translate({vector}) : 벡터 값을 현재 위치에 더하는 함수
     - 벡터 : 방향과 그에 대한 크기 값
     - Vector3(x, y, z)
     - Vector3는 3차원
     - Vector2는 2차원
   - Vector 값에 Input.GetAxis를 통해 이동 값 조정 가능
---
## 2023년 05월 12일
---
### 당일 공부 내용
- https://blog.naver.com/gold_metal/220472492907
- https://docs.unity3d.com/kr/2021.3/Manual/class-Rigidbody.html
- https://solution94.tistory.com/27
---
### 오브젝트 점프 구현
---
1. 중력 시스템 구현
  - 중력 시스템은 로직적으로 하는 것이 아닌 유니티 자체 기능 존재
    - Edit -> Project Settings -> Physics(2D프로그램의 경우 Physics 2D로) -> Gravity로 중력 질량 설정(-9.81이 일반 중력 가속도)
    - Add Component -> Rigidbody 추가
      - Mass : 오브젝트의 질량
      - Drag : 공기저항
      - Use Gravity : 중력의 영향을 받음
2. 점프 시스템 구현
  - Move.cs에 새로 구현
  - 골드메탈 원형 강의와 약간의 수정
    - 함수들 외부에 Rigidbody rigid로 설정
    - Moving, Jump 함수 생성
    - 함수 밖에 JumpPower와 MoveSpeed 변수 생성
      - Inspector에 Script를 넣어주고 해당 Inspector에서 JumpPower와 MoveSpeed를 조정해줘서 이동과 점프 구현
      - 해당 로직만 짤 시 점프버튼 연타시 무한 점프
        - 해당 문제 해결방안
          - bool 형태로 isJump 변수 생성(현재 점프 상태인지 파악)
          - Jump 함수 내부에 점프 상태인지 파악해서 점프 가능한지 여부 구현
          - 해당 로직에서 끝낼 시 점프를 단 1번만 가능
          - void OnCollisonEnter(Collision collision) 추가
          - 해당 함수 안에 만약 "Ground(다른 변수명 가능)"에 닿으면 실행되도록 생성{if(collision.gameObject.ComparreTag("변수명"))}
          - 바닥을 구성하는 Object에 Ground tag 추가(Inspector Tag에 들어가서 추가)
          - 무한 점프 해결
3. 응용(2단 점프) -> 자체 로직 개발(자료 X)
  - isJump를 int로 받아서 isJump가 2 미만일 때 점프 가능하게 생성
  - 점프할 때마다 isJump++
  - 바닥에 닿으면 다시 isJump를 0으로 갱신

### 문제점 및 해결
- 점프 후 내려오는 속도가 느리다 느낌
- 찾아보니 Rigidbody의 Drag에 따라 낙하 속도가 달라진다 함
- Drag가 클수록 떨어지는 속도가 느림
- 하지만 음수로 떨어뜨릴수 없어 낙하속도를 빠르게 할 수는 없음
- 중력가속도를 바꿔주면 빨라진다고 함
- 중력을 바꿔주니 JumpPower가 약하게 받아짐
- Mass를 바꿔줌(JumpPower를 바꿔주거나 Mass를 바꿔주어 점프 속도를 바꿔줌)

---
## 2023년 05월 14일
---
### 당일 공부 내용
- https://youtu.be/gnO1GVRuKxk
- https://youtu.be/QGFaA3WYAwk
- https://youtu.be/kYmYCMAiOUk
- https://youtu.be/h_MA36TGFsc
- https://youtu.be/salZ7t98xi8
---
### 목표지점으로 이동시키기
---
1. MoveTowards(등속이동)
  - 매개변수는 현재위치, 목표위치, 속도로 구성
  - 매개변수에 비례하여 속도 증가
2. SmoothDamp(부드러운 감속 이동)
  - 매개변수에 반비례하여 속도 증가
  - ref : 참조접근 -> 실시간으로 바뀌는 값 적용 가능
  - SmoothDamp 사용시 보통 zero 값을 씀
3. Lerp(선형보간)
  - SmoothDamp보다 감속 시간이 김
  - MoveTowards와 받는 매개변수는 같으나 소고 최대값은 1
4. SLerp(구면 선형 보간)
  - 호를 그리며 이동(포물선 이동)
---
### 델타타임
---
1. 사용법
  - Translate : 벡터에 곱하기
  - Vector 함수 : 시간 매개변수에 곱하기
  - 입력 받을 때 뒤에 Time.deltaTime을 곱해줌
2. 개념 : 이전 프레임의 완료까지 걸린 시간
  - 사용자의 컴퓨터마다 프레임이 다르기 때문에 최적화와 관련된 내용
  - 프레임이 적으면 크고, 프레임이 많으면 작음
---
### 물리법칙 적용
---
- 저번에 이동 강의를 듣고 점프 기능을 구현해보고 싶다는 마음으로 대략적인 강의는 보았고 강의영상을 다시 봄(복습 및 심화 느낌)

---
1. Unity Editor만 사용
2. Unity는 Component 기반 엔진
3. Rigidbody를 Add Component로 추가(물리효과를 받기 위한 컴포넌트)
4. Collider 삭제시 다른 오브젝트와 충돌이 되지 않음(충돌체)
  - Radius는 반지름으로 충돌 기준을 바꿔줌
5. Mass 무게(낙하 속도는 바뀌지 않음 충돌이 무거워지는지 가벼워지는지 여부에 영향)
6. Rigidbody - Use Gravity : 중력에 영향을 받는지 여부
7. Rigidbody - Is Kinematic : 외부 물리효과 무시 -> script로만 이동 가능 - 움직이는 함정을 만들 때 유용
8. Material 설정(재질) : 오브젝트의 표면 재질을 결정하는 컴포넌트(Defalut는 편집 불가)
  - Asset에 새로 Material을 추가하여 설정(편집 가능)
  - Albedo : 색상
    - Alㅠedo 옆 작은 박스에 이미지 파일을 집어 넣으면 Texture 적용 가능
  - Metalic : 금속 재질 수치
  - Smoothness : 빛 반사 수치
  - Emission : 텍스쳐 밝기(발광) 조절
    - 빛이 물리적으로 나오는 것은 아님
    - 빛을 내는 Component는 Light라고 따로 있음
  - Tilling : 텍스쳐 반복 수치
9. Physics Material : 탄성과 마찰을 다루는 물리적인 재질(물리 Material)
  - 드래그해서 추가시 새로운 Component로 추가되는 것이 아닌 Collider의 Material에 추가됨
  - Physics Material - Bounciness : 탄성력, 높을수록 많이 튀어오름
  - Physics Material - Bounciness Combine : 튀어 오른 후 다음 탄성을 계산하는 방식(최대값 1)
    - Averrage : 이전 탄성의 중간값
    - Maximum : 대부분 사용하는 탄성, 이전 탄성 보다 점점 커짐(1로 줄 경우)
  - Physics Material - Friction : 마찰력
    - Static Friction : 정지 시 마찰력
    - Dynamic Friction : 이동 시 마찰력
    - Friction Combine : 다음 마찰력을 계산하는 방식
10. 물체 필수요소 : Mesh, Material, Collider, RigidBody

---
### 물체 움직이기
---
1. Rigidbody 변수명으로 변수 정의
2. 함수 안에 GetComponent로 할당
3. rigid.velocity = Vector3.right(left);로 오른쪽(왼쪽)으로 움직이게 만들어줌
4. rigid.velocity = new Vector4(x, y, z);로 설정한 x, y, z 방향으로 이동하도록
5. RigidBody 관련은 ~~FixedUpdate~~ Update에 작성
6. rigid.AddForce -> 힘의 방향을 지정
  - rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
    - FoeceMode : 힘을 주는 방식(가속, 무게 반영) -> Mass가 클 수록 더 큰 힘이 필요
      - Impulse : 가장 많이 씀
  - AddForce로 점프 구현
    -  ``` if(Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);
        }
        Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vec, ForceMode.Impulse);
  - 활용해본 결과 원하는 Jump가 잘 되지 않아 기존 이동 방식을 사용하는 것이 좋아보임
  - 재확인 결과 기존 방식 사용시 이동 후 오류가 발생
7. 회전력 주기
  - AddTorque : 회전력 주기
    - rigid.AddTorque(Vector3.back); 형식
    - Vec을 축으로 삼기 때문에 이동 방향에 주의

---
### 물리 충돌 이벤트
---
1. 닿을 시 재질 변경
  - MeshRenderer를 통해서 변경
  - OnCollisionEnter : 물리적 충돌이 시작할 때 호출되는 함수
  - OnCollisionExit : 물리적 충돌이 끝날 때 호출되는 함수
  - OnCollisionStay : 물리적 충돌 중일 때 호출되는 함수
  - Color : 기본색상 클래스
  - Color32 : 255 색상 클래스
  - Collision : 충돌 정보 클래스
2. 충돌 시 특수한 이벤트 발생
  - trigger로 사용하고 싶은 Object에 is Trigger 체크
  - OnTriggerStay 함수를 사용
    - OnTrriger 함수 안에 if문으로 만약에 닿으면 어떠한 작동을 하도록 조작

---
### 오늘의 오류
---
1. Jump가 제대로 기능하지 않고 이동 시 다른 오브젝트에 닿으면 오류가 생김
2. 해결 : 영상에는 FixedUpdate에 함수를 정의해야 한다고 했지만 실제로는 Update에 지정해주어야 정상 작동함 -> 영상의 오류

---
## 2023년 05월 15일
---
### 당일 공부 내용
- https://youtu.be/k4YUJy-otDs
---
### UI
---
강의 영상과 현재 사용하는 UI가 달라짐 기본 개념만 인지하고 필요시 주의해서 사용할 것
1. 화면
  - World : 카메라 O
  - Screen : 카메라 X
2. Hierachy -> UI -> Canvas 생성(Screen 생성)
3. Hierachy -> UI -> Text : 문자열 생성
  - Font는 무료인 것을 찾아볼 것 아니면 사용 가능한 폰트 찾아봐야 함
  - Overflow : 문자열이 넘어가도 보이도록 -> 종종 깨지는 경우 있으니 주의
4. Hierachy -> UI -> Image : 이미지 UI
  - 적용하고 싶은 이미지를 클릭해서 Texture Type을 Sprite로 바꿔 주어야 적용 가능(초기값인 Default는 불가능)
  - 드래그해서 Source Image에 적용
  - Preserve Aspect나 Set Native Size를 통해서 원본 비율을 맞추거나 원본 크기에 맞출 수 있음
  - Image Type을 통해서 원하는 방식으로 이미지 표현 가능
  - Width, Height 등으로 프레임 크기 파악
  - Image Type -> Filled
  - Filled 기능으로 쿨타임 효과 구현 가능(Fill Amount로 원형으로 드러나게 가능)
  - 이미지의 순서는 Hierachy에서 아래에 있을 수록 나중에 그려지므로 아래에 만들어지면 나중에 만들어짐
5. Hierachy -> UI -> Button
  - 내부의 Text로 적혀있는 글자 바꾸기 가능
  - Button -> Interactable : 누르면 기능하는지 여부 -> 눌렀다 떼는 과정이 하나의 동작 누르기만 하면 작동 X
    - Color Tint : 색을 바꿔줌
      - Nomal Color : 일반적인 상황의 색
      - Highlighted Color : 마우스를 올렸을 때 색
      - Pressed Color : 눌렀을 때 색
      - Disabled Color : 사용 불가능할 때 색
      - Navigation : tab을 눌렀을 때 기능
      - On Click : 클릭했을 때 실행할 기능
6. 앵커
  - 원하는 위치에 UI를 위치시켜도 실행하면 안 맞는 경우 존재 -> 버그
  - Rect Transform(Object의 Transform)의 왼쪽 위 사각형을 클릭해 Anchor Presets를 통해 파악
  - 앵커의 빨간 점 : 캔버스의 기준점
  - 앵커의 파란 점 : 컴포넌트에서의 기준점(Shift 클릭)
  - 앵커 중앙 네모 : 컴포넌트의 위치(Shift + Alt)