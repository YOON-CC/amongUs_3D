### 어몽어스3D란 우주선을 고치기 위해 어몽어스 캐릭터가 여러 장애물들을 피해가며 볼트를 수집하고 점수를 올리는 게임입니다.
<br>
<br>


어몽어스3D

https://github.com/YOON-CC/amongUs_3D/assets/87313979/df9d0f4f-5051-473e-97c8-a4f032a6941f




<br>
<br>

게임소개
![image](https://github.com/YOON-CC/amongUs_3D/assets/87313979/f0adb202-701d-4187-84cf-6ff331dd63dc)
<br>
<br>

캐릭터 디자인
>blender를 활용하여 여러 영상들을 참고하여 디자인을 하였습니다.
![어몽어스디자인](https://github.com/YOON-CC/amongUs_3D/assets/87313979/81e4feba-7f1f-4068-8ebd-e6efebf50192)
<br>
<br>

인터렉션

![image](https://github.com/YOON-CC/amongUs_3D/assets/87313979/a7ca0288-a86c-44ad-b7df-8e7f1bde611d)
>▶ GAMEStart스크립트는 게임 시작화면에서 다음씬으로 넘어가는 역할을 수행<br>
>▶ PlayerController와 Movement의 경우에는 캐릭터의 움직임을 담당<br>
>▶ Movement의 경우에는 unity에서 미리 z축의 이동 속도를 정의하여 게임시작과 동시에 자동으로 앞으로 나아간다.<br>
>▶ Volt의 경우 아이템과 충돌을 하면 이펙트 효과가 생성<br>
>▶ PlayerCollision의 경우 장애물, 아이템, 그리고 땅에 떨어졌을때의 투명한 오브젝트에 충돌을 감지하여 게임이 재시작 되도록 설정<br>
>▶ GameController의 경우 게임을 시작하면 게임제목 및 클릭시 게임이 시작이 되도록 하였으며, 아이템을 획득하면 수치가 올라가도록 하는 역할을 담당<br>
>▶ CameraController스크립트는 카메라가 어몽어스와 입력한 거리를 유지하며 계속 캐릭터에 고정이 되며 따라다니는 역할<br>
>▶ Area의 경우 맵이 생성 및 파괴가 되는 역할을 하며 이는 AreaSpawner스크립트를 호출<br>
>▶ AreaSpawner스크립트의 경우 5가지의 맵이 기본값으로 주어진 맵부터 시작해서 변수의 값을 통하여 특정 조건문에 진입을 하여 이후 순차적으로 맵이 호출이 되는 것이 아닌 랜덤으로 맵이 호출<br>

