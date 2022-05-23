# 걸어서 가상의 속으로(walk-into-virtual)
Steam VR _ walk into virtual
캡스톤 디자인 - 원광대학교 디지털콘텐츠공학과 <지박령>

# 과제설계 목표
전 세계적으로 코로나바이러스 확산이 퍼지며 국외는 물론이고 국내 여행까지 불가한 상황이다.
관광을 원하는 사람들을 위해 VR을 이용한 관광콘텐츠 제작을 위해 알아보던 중 전국적인 명소를 대상으로 하는 VR 관광콘텐츠가 많이 없다는 것을 알게 되어 한국관광콘텐츠를 주제로 선정하게 되었다. 걸어서 가상 속으로는 VR 기기를 소지하면 공간의 제약을 받지 않고 자유롭게 어디서든 대한민국의 여러 관광지를 구경할 수 있으며 관광지를 활용한 게임 및 콘텐츠를 이용할 수 있다.

# 작품의 특징 및 기대효과
‘걸어서 가상의 속으로’는 VR 기기를 쓰고 실제로 걸어보며 관광을 할 수 있어 콘텐츠의 몰입도를 높였다. 관광지를 구경하는 것뿐만 아니라 이벤트 체험 요소를 추가하여 사용자의 흥미를 끌어낼 수 있도록 구현하였다. 코로나로 인해 비대면 시대가 되어가는 현재 외국인, 내국인들의 국내 여행에 대한 갈증을 해소하며 다음에 관광의 경험을 다시 한 번 만끽하고 싶어 관광지를 재방문하여 방문율을 높이거나, 다른 관광객들에게 홍보 효과를 얻을 수 있다.

# 아이디어 스케치
코로나로 인한 비대면 시대에 관광객 유치가 어렵다는 뉴스를 접하게 됨. 한국관광 100선을 참고하여 관광지를 선정 후 실제와 유사하게 구현하고자 함.
- 관광지의 주요 건물을 모델링 한 후 나무, 의자 등을 배치하여 디자인함.
- 사용자의 흥미를 위해 이벤트 요소 추가
- 관광 시작 시 지역명과 관광지에 대한 오디오 출력

![image](https://user-images.githubusercontent.com/76396597/169792726-5c9fc839-8e00-47f0-b452-81d9c4b80dd0.png)
출처: 2019 ~ 2020 한국관광 100선 자료(문화체육관광부)

# 개발 환경
![image](https://user-images.githubusercontent.com/76396597/169796224-07261c9e-b833-4be7-8c7f-a4217965e14e.png)


# 설계 제작 과정
1. 걸어서 가상의 속으로 인트로 화면 <깜깜한 어둠 속 한옥 문 앞에서 시작>
![image](https://user-images.githubusercontent.com/76396597/169793270-facb147d-6dc5-4993-9594-96473ac865ae.png)

2. Vive Controller가 한옥 문과 닿으면 자동으로 한옥 문이 열림

3. 음성 지원 & 푯말 => 장소가 어디인지를 알 수 있다. ==> 해당 장소를 관광 
● 해당 지역과 어울리는 배경음악(인연 Inst) 설정
![image](https://user-images.githubusercontent.com/76396597/169793439-b5f870aa-4a6b-4d46-bf36-a28d68bfc9bc.png)

4. 죽녹원 지역 관광 후 다음 지역으로 넘어가기 위해 Vive Controller로 손 모양을 Touch 
● 판다 모델링 => 손 흔드는 모습 구현
![image](https://user-images.githubusercontent.com/76396597/169793501-1be8b4ad-f8dd-4c1d-b301-8f14c24dee36.png)

5. 전주의 전동성당을 관광 & 수녀님 기도하는 모습 구현 
● 해당 지역과 어울리는 배경음악(canon) 설정 & 음성 지원 및 푯말
![image](https://user-images.githubusercontent.com/76396597/169793552-64d2b851-9c37-43d0-ba4c-c4f0fd66d4ec.png)

6. 거제의 바람의 언덕을 관광
● 풍차 날개 회전 및 주변의 캐릭터들의 애니메이션 구현
● 해당 지역과 어울리는 배경음악(바람 소리) 설정 & 음성 지원을 통한 지역 안내
![image](https://user-images.githubusercontent.com/76396597/169793602-d05c9011-b592-45e1-bf99-ff5088f19c1b.png)

7. 바람의 언덕에서 즐기는 양궁 게임
● 5개의 양궁 과녁 맞힌 후 다음 장소 이동
![image](https://user-images.githubusercontent.com/76396597/169793677-6ac3730b-af3b-4ca9-bb66-ff45f6381713.png)

8. 익산 미륵사지 석탑을 관광 & 다음 장소로 이동하기 위해 손 모양을 Touch
● 해당 장소와 어울리는 배경음악(바람 소리) 설정 & 음성 지원을 통한 지역 안내

9. 익산 미륵사지 석탑에서 즐기는 투호 게임
● 상자 속 화살 5개를 넣은 후 다음 장소로 이동 
![image](https://user-images.githubusercontent.com/76396597/169793753-9e6a7d2e-fe23-4045-8715-e4b56134be9d.png)

10. 서울 서대문 형무소 내부 관광
● 해당 장소와 어울리는 배경음악 설정(대한독립만세 +　8호 감방의 노래)
● 교도관 & 죄수 애니메이션 적용, 다음 장소로 넘어가기 위해 손 모양 Touch
![image](https://user-images.githubusercontent.com/76396597/169793782-e69cc6e8-1f7a-4b4e-925a-41bfa18b6448.png)

11. 서울 남산타워 불꽃놀이 관람
● 남자 & 정자 밑에서 쉬고 있는 여성의 애니메이션 적용, 불꽃 파티클 제작
● 다음 장소로 넘어가기 위해 손 모양 Touch 
![image](https://user-images.githubusercontent.com/76396597/169793799-ff2e1528-3bd7-4872-bb3d-2ddfb8c2f9c4.png)

12. 서울 리듬 게임 즐기기 
● 해당 게임과 어울리는 음악 설정(아리랑) & 30초 후 다음 지역으로 이동 
![image](https://user-images.githubusercontent.com/76396597/169793831-ce030a35-d42e-4d3d-a631-95a4cb6350cf.png)

13. 강릉 주문진 등대, 포항 호미곶 => 드라마 “도깨비” 장면 패러디
● 남자가 들고 있는 메밀꽃을 잡을 시 드라마 “도깨비” 속 명대사 나온다.
● 해당 지역과 어울리는 배경음악(Beautiful) 설정
● 다음 장소로 넘어가기 위해 손 모양 Touch
![image](https://user-images.githubusercontent.com/76396597/169793849-280d73e7-942d-4f02-ad9c-c6c38fcc6bb8.png)

13. 제주도의 감귤밭에서 즐기는 감귤 따기 체험 
● 해당 지역과 어울리는 배경음악(제주도의 푸른 밤) 설정
● 감귤을 바구니에 넣기 위해 Vive Controller로 감귤을 집은 후 바구니에 넣기
=> 감귤 Object에 Sphere Collider, RigidBody, Mesh Collider 추가
![image](https://user-images.githubusercontent.com/76396597/169793885-adfbd621-8b2e-49e2-a1c3-70ebb49d48f6.png)

14. 제주도 관광을 끝마칠 때 한옥 문이 Vive Controller와 맞닿으면 자동으로 열린 후 투어 완료를 알려주는 이미지가 나옴
![image](https://user-images.githubusercontent.com/76396597/169793903-b0c49bc6-1d75-45cf-b792-9cff8fe3be02.png)

# 걸어서 가상의 속으로 모델링
노은혜 : 한옥 문, 죽녹원- 입구, 죽녹원 - 정자, Lamp, 바람의 언덕- 풍차, 익산- 미륵사지 석탑, 화살, 서대문 형무소 내부, 감귤밭 통, 가랜드, 귤
박보영 : 남산타워
방지원 : 전주- 전동성당, 호미곶

# 구현과정
https://leeeunhye.tistory.com/3

# 프로젝트 기간 
2021.3.2 ~ 2021.6.4

# 담당직무 
노은혜(팁장) - 안내음성 추출, 자료수집, 작업내용 정리, 3D 모델링, C# 코딩, UI 제작, 캐릭터 애니메이션, Asset 수집
박보영 - PPT 제작, 영상편집, 배경음악 추출, Asset 수집, UI 제작, 3D 모델링
방지원 - 자료수집, 작업내용 정리, 3D 모델링, c# 코딩, 캐릭터 애니메이션, UI 제작, Asset 수집

# 구현결과 영상
https://youtu.be/EySNfgm8-aE
2분 26초부터 구현결과 영상입니다.
