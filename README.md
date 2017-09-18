# Ilhwa TM - 파이프 생성 라인 관리기
2012년 제작.  
Ilhwa Stainless 의 파이프 생성 공정 라인에서 쓰이는 프로그램을 새로 만든 것.  
이전 버전의 SW는 한 곳(View) 에서 다수의 테이블 내용을 끌어다 썼기 때문에 느린건 둘째치고 코드가 상당히 복잡 했다.  
그래서 자체적으로 MVC 및 SQL Mapper를 만들어서 적용하고 이것으로도 넘치는 추가 요청사항이 많아서 중간에 엑셀(xls) 파일에 Model 측 설정 기능을 넣어 엄청나게 추상화를 시켰었다.

## 사용기술 및 환경
* C#.NET 3.5 WinForm (GDI+)
* MVC Pattern 적용
* 자체 SQL Mapper (Query Info) 제작 및 적용
* MS-SQL
* 바코드 출력 기능 (Serial Port & 템플릿 코드 분리)
* 각종 설정 기능 (레지스트리, 엑셀, XML, ini 텍스트 등)
* 터치스크린 UI 최적화 (ex: 버튼 크게 만들기 등)

## 비고
사정상 보안에 민감한 내용은 제거함.

## Licence
MIT

## Screen Shots
![](https://github.com/thesoncriel/ilhwa.tm/blob/master/screenshots/001.png)
![](https://github.com/thesoncriel/ilhwa.tm/blob/master/screenshots/002.png)
