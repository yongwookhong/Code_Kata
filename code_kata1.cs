using System;

// 두 수의 차
public class Solution
{
    public int solution(int num1, int num2)
    {
        int answer = num1 - num2;
        return answer;
    }
}
 
// 두 수의 곱
public class Solution
{
    public int solution(int num1, int num2)
    {
        int answer = num1 * num2;
        return answer;
    }
}

// 몫 구하기
public class Solution
{
    public int solution(int num1, int num2)
    {
        int answer = num1 / num2;
        return answer;
    }
}


//나이 출력
//2022년을 기준으로 출생연도를 return하는 솔루션
//나이는 태어난 연도에 1살이며 1년마다 1씩 증가
public class Solution
{
    public int solution(int age)
    {
        int answer = 2022 - age + 1;
        return answer;
    }
}

//숫자 비교하기
//두수가 같으면 1 다르면 -1 을 return 하는 solution 함수
public class Solution
{
    public int solution(int num1, int num2)
    {

        return num1 == num2 ? 1 : -1;
    }
}



// 두수의 합
// 정수 num1과 num2가 주어질 때, num1과 num2의 합을 return 하도록 solution 함수를 완성
public class Solution
{
    public int solution(int num1, int num2)
    {
        int answer = num1 + num2;
        return answer;
    }
}