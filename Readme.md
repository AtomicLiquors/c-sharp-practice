### C# Practice
C# 관련 내용을 공부하는 저장소.  

<br>

### To-Do
과제 테스트 C#으로 풀기  
백준 브론즈 문제 C#으로 풀기


## 🔹 1. 기초 문법 및 구조 익히기 (1주)

> 목표: Java 기반으로 C#을 이해하고 코드를 읽을 수 있게 하기
> 

### 주제:

- C# 프로젝트 구조 (.csproj, 솔루션 구조 등)
- `Main()` 함수와 entry point
- 기본 타입과 타입 시스템 (nullable, value vs reference)
- `var`, `dynamic`, `object`
- 조건문 / 반복문 / switch (with pattern matching)
- 배열, List, Dictionary

### 실습:

- Java와 C#에서 동일한 프로그램 작성 (ex. 계산기, 피보나치 등)
- LINQ 없이 간단한 컬렉션 조작

---

## 🔹 2. 객체지향 비교 학습 (1주)

> 목표: C#의 객체지향 구조를 Java와 비교해서 이해
> 

### 주제:

- 클래스, 인터페이스, 상속, 다형성
- `override`, `new` 키워드 차이
- 접근 제어자 (`public`, `internal`, `protected internal`)
- `readonly`, `const`, `static`의 차이
- Properties (`get; set;`)와 Java-style getter/setter의 차이
- 구조체 (`struct`)와 클래스 차이
- record type (immutable 객체 표현 방식)

### 실습:

- Java 객체 모델을 C#으로 변환, C# 객체를 Java로 변환

---

## 🔹 3. C# 고유 기능 익히기 (1~2주)

> 목표: Java에는 없는 C#만의 기능 익히기
> 

### 주제:

- Delegates vs Java의 Functional Interfaces
- Events / Observer 패턴
- Lambda와 LINQ 기본 문법
- Nullable Types (`int?`, `?.`, `??`, `??=`)
- Pattern Matching
- `using` 문과 IDisposable 패턴
- async/await (Java의 CompletableFuture와 비교)

### 실습:

- LINQ로 List 필터링 → Java 스트림으로 변환
- 이벤트 구독 코드 → Java 옵저버 패턴으로 변환
- `async Task<T>` 코드 → Java Future / Executor로 마이그레이션

---

## 🔹 4. 실무 마이그레이션 대비 (.NET 환경 분석) (2~3주)

> 목표: 실제 마이그레이션 대상 C# 코드 이해와 Java로 옮기는 데 필요한 지식 확보
> 

### 주제:

- C#에서 자주 사용하는 라이브러리와 Java 대응 방법
    - 예: `System.Net.Http`, `Newtonsoft.Json`, `Entity Framework`, `Dapper`
- C#의 DI 프레임워크 (`Microsoft.Extensions.DependencyInjection`)
- C#의 Unit Test 프레임워크 (NUnit, xUnit) → JUnit으로 마이그레이션
- .NET Core vs .NET Framework 차이
- C#의 프로젝트 구조를 Java Maven/Gradle 구조로 재해석

### 실습:

- C# 서비스 코드 일부 Java로 옮기기
- REST API Client / JSON 직렬화 코드 마이그레이션

---

## 🔹 5. 도구 및 마이그레이션 전략 정리 (1주)

> 목표: 효율적인 마이그레이션 도구와 전략 확보
> 

### 주제:

- C# to Java 마이그레이션 자동화 도구 조사 (예: Sharpen)
- 코드 Diff 툴, 문서 자동화 도구
- 리팩토링 전략 (1:1 매핑 vs 재설계)
- 테스트 우선 전략 (기존 테스트 -> Java에서 동일 결과 보장)

---

## 🔹 추천 학습 자료

- [C# Programming Yellow Book by Rob Miles (무료 PDF)](http://www.csharpcourse.com/)
- [Microsoft Docs - C# Language](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [C# for Java Developers](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/inside-a-program/csharp-for-java-programmers)

---

## ✍️ 보너스 팁: Java 개발자 관점에서 꼭 짚고 넘어갈 개념

| C# 개념 | Java 개발자가 주의할 점 |
| --- | --- |
| `var` | 타입 추론이 더 자유롭고 동적인 경우도 있음 |
| `dynamic` | Java에는 없는 특이한 타입. 런타임 바인딩 주의 |
| `async/await` | Java보다 훨씬 간단하지만, 내부 동작 이해 필요 |
| `LINQ` | Java Stream API와 매우 유사하나, 문법 차이 큼 |
| `record`, `with` | Java 16+에서 도입된 `record`와 유사 |
