- About Project

UNITY3D와 VR기기를 활용해서 운전 시뮬레이션을 할 수 있도록 제작하는 게임입니다. 운전 기능 이외에도 차량과 배달에 영향을 미치는 다양한 상호작용 요소들을 넣어 재미를 더했습니다. 

기획서/구현방법

[가상증강최종.pdf](https://prod-files-secure.s3.us-west-2.amazonaws.com/b9eb5b66-d4a5-4054-89c7-9926a800ce82/07d3c476-1619-4c09-aa55-e2240ce6f7de/%E1%84%80%E1%85%A1%E1%84%89%E1%85%A1%E1%86%BC%E1%84%8C%E1%85%B3%E1%86%BC%E1%84%80%E1%85%A1%E1%86%BC%E1%84%8E%E1%85%AC%E1%84%8C%E1%85%A9%E1%86%BC.pdf)

- 역할
1. 코루틴을 활용해 신호등 개발 —> 초록불과 빨간불이 일정 시간마다 깜빡거리도록 했고, 빨간불일 경우에 신호등을 지나가면 경찰차 인스턴스가 생성되어 플레이어를 쫓도록 개발
2. 경찰차 길찾기 시스템 —> 경찰차가 생성되면 A*길찾기를 활용해 도로에서 플레이어를 쫓을 수 있도록 개발. Unity AI를 활용함.
3. 코인 등 아이템 → DOTween 라이브러리를 활용해 아이템들이 빙글빙글 도는 등 지속적인 애니메이션을 할 수 있도록 개발. 
4. 아이가 신호등 건너는 동안 차에 닿으면 경찰차 소환되도록 개발

- 데모 영상

[KakaoTalk_Video_2023-12-14-20-37-00.mp4](https://prod-files-secure.s3.us-west-2.amazonaws.com/b9eb5b66-d4a5-4054-89c7-9926a800ce82/47e67554-a553-4ab6-9f91-bee99ce0b08a/KakaoTalk_Video_2023-12-14-20-37-00.mp4)

[KakaoTalk_Video_2023-12-14-20-37-27.mp4](https://prod-files-secure.s3.us-west-2.amazonaws.com/b9eb5b66-d4a5-4054-89c7-9926a800ce82/982876ab-edc7-4c41-bb22-ed5f9067b97a/KakaoTalk_Video_2023-12-14-20-37-27.mp4)
