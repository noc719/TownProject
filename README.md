스파르타 타운 만들기 과제

#활동 목표
# 필수 구현과 구현을 위한 기능 활용에 대한 이해

#구현한 기능 : 
## 캐릭터 만들기 : 활용한 에셋 2D Character Sprite Animation - Penguin

## 캐릭터 이동 : InputSystem 을 활용하여 wasd 방향키로 조작하고 마우스 커서를 기준으로 캐릭터의 방향 전환

## 방만들기 : 타일맵과 타일맵 콜라이더를 활용하여 맵을 제작 기능 구현에 집중하기 위해 예시와 비슷하게 제작

## 카메라 따라가기 : CameraController.cs 에서 코드작성 카메라가 player 오브젝트를 따라가게
하기위해서 Update 문안에 player의 프레임당 transform.position 을 받아오고 카메라와 플레이어 사이벌어진 만큼 거리를 카메라에 transform.Translate 로 더함

## 캐릭터 애니메이션 추가 : 에셋에 따로 애니메이션 파일이 존재하였지만 기능을 익힌다는 것에
중점을 두기위해 직접 추가

## 이름 입력 시스템 : Input Field 에 대한 정보를 검색을 통해 찾아서 이해해보았고 
TMP_Text 계열 UI를 작성할 때 한글 폰트가 깨지는 것을 해결하기위해 변환하는 법도 배움 
Scene을 StartScene 과 MainScene 으로 나누어 입력받은 이름값을 DontDestroyOnLoad 메소드를 사용하여 MainScene의 Text에 전달

