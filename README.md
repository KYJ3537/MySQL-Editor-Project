# 도서 대출 및 관리 프로젝트 (2024 - 04 - 08)

## Winform GUI에 보여지는 모든 기능 구현 완료.

### Database 테이블구조
![dbtable](https://github.com/KYJ3537/MySQL-Editor-Project/assets/107566312/27ea0958-f548-4a11-84c4-2a5d481b7830)

### Invite 동작구조
#### 로그인
![login](https://github.com/KYJ3537/MySQL-Editor-Project/assets/107566312/14264e1a-d2c7-4460-968c-f8dbf92ee2d3)
- BOOL 타입의 Login_funtion()을 호출.
- 호출된 함수는 Sql 연결 데이터를 가진 MySqlConnection 객체를 새롭게 생성하고 접속.
- 아이디를 찾기 위해 변수에 SELECT SQL문을 담음.
- 실행할 MySqlCommand 객체를 새롭게 생성.
- MySQLDataReader 클래스를 사용하여 데이터베이스로부터 읽은 데이터를 처리하고 변수에 담음.
- 담은 변수를 통해 데이터베이스로부터 읽은 정보를 처리하고 로그인 성공 유무 결정.
- 성공했다면 Sql 연결 데이터를 가진 MySqlConnection 객체를 새롭게 생성하고 접속.
- 마지막 로그인 시간을 삽입하기 위해 변수에 UPDATE SQL문을 담음.
- 각 SQL문 실행에 예외처리.
  
#### 회원가입
![register](https://github.com/KYJ3537/MySQL-Editor-Project/assets/107566312/e7cd6617-2af5-4026-a3ac-581fc87f0b00)
- BOOL 타입의 함수를 호출.
- 호출된 함수는 Sql 연결 데이터를 가진 MySqlConnection 객체를 새롭게 생성하고 접속.
- 아이디가 중복되는지 아이디 조회를 위한 변수에 SELECT SQL문을 담음.
- 실행할 MySqlCommand 객체를 새롭게 생성.
- 아이디 중복 검증 이후 테이블에 데이터를 삽입하기 위해 변수에 INSERT SQL문을 담음.
- 실행할 MySqlCommand 객체를 새롭게 생성.
- MySQLDataReader 클래스를 사용하여 데이터베이스로부터 읽은 데이터를 처리하고 변수에 담음.
- 담은 변수를 통해 데이터베이스로부터 읽은 정보를 처리하고 회원가입 성공 유무 결정.
- 각 SQL문 실행에 예외처리.

### FindPassword 동작 구조
#### 비밀번호 찾기

- VOID 타입의 함수를 호출.
- 호출된 함수는 Sql 연결 데이터를 가진 MySqlConnection 객체를 새롭게 생성하고 접속.
- 아이디 조회를 위한 변수에 SELECT SQL문을 담음.
- 실행할 MySqlCommand 객체를 새롭게 생성.
- MySQLDataReader 클래스를 사용하여 데이터베이스로부터 읽은 데이터를 처리하고 변수에 담음.
- 담은 변수를 통해 데이터베이스로부터 읽은 정보를 처리하고 비밀번호 찾기 성공 유무 결정.
- SQL문 실행에 예외처리.
  
### Main 동작 구조
#### 책 대여 리스트
![main1](https://github.com/KYJ3537/MySQL-Editor-Project/assets/107566312/17b509a9-bca9-43aa-b2be-e38d430294f7)
![main1_2](https://github.com/KYJ3537/MySQL-Editor-Project/assets/107566312/2812abe8-e1d0-4c33-9ccf-aaec77c1ff9e)
#### 내가 대여 중인 도서 목록
![main2](https://github.com/KYJ3537/MySQL-Editor-Project/assets/107566312/08dac9c3-0fd2-49a6-a4c2-68e0993121d6)
#### 관리자
![main3](https://github.com/KYJ3537/MySQL-Editor-Project/assets/107566312/dc454e80-c50b-4490-8178-0a0427a6e034)

### BookView 동작 구조
![main1_1](https://github.com/KYJ3537/MySQL-Editor-Project/assets/107566312/c2f10bce-ce86-40d1-928a-6746de5badc4)

### 프로그램의 완성도를 높이기 위해서 추후 추가할 일 기록 

-> MySql Database에 접근하는 방식 보안
- Type A : Client에서 데이터를 담은 요청 데이터 패킷을 암호화해서 전송 이후 Server에서 받은 정보를 복호화하고 처리 후 결과를 다시 암호화하여 Client에 전송하는 TCP 방식 채용 방법.
- Type B : MySql Connection, Execute시 필요한 데이터를 암호화하여 작동하는 방법.
  
-> 동작 로그 DB 및 문서화 저장
- 로그인, 대여, 반납 로그를 수집할 또 다른 MySQL 테이블을 추가하고 동작마다 INSERT를 해줘야 될 필요가 있음.
- 작성된 LOG를 로컬 컴퓨터 혹은 서버를 구축하여 해당 데이터를 관리자의 편의성을 위해 직관적인 문서 형식으로 저장해야 될 필요가 있음.
  
-> 코드 리팩토링
- 가독성, 분석 및 추후의 코드 수정을 위해 Rename, 더 효율적인 작동 방식 존재 유무 확인해보기.
