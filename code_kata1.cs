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



//두수의 나눗셈
// 정수 num1과 num2가 매개변수로 주어질 때, num1을 num2로 나눈 값에 1,000을 곱한 후 정수 부분을 return 하도록 soltuion 함수를 완성해주세요.

public class Solution
{
    public int solution(int num1, int num2)
    {
        double answer = (double)num1 / num2 * 1000;
        return (int)answer;
    }
}


//각도기
//각에서 0도 초과 90도 미만은 예각, 90도는 직각, 90도 초과 180도 미만은 둔각 180도는 평각으로 분류합니다.
//각 angle이 매개변수로 주어질 때 예각일 때 1, 직각일 때 2, 둔각일 때 3, 평각일 때 4를 return하도록 solution 함수를 완성해주세요.


public class Solution
{
    public int solution(int angle)
    {
        int answer = 0;
        if (angle > 0 && angle < 90)
        {
            answer = 1;
        }
        else if (angle == 90)
        {
            answer = 2;
        }
        else if (angle > 90 && angle < 180)
        {
            answer = 3;
        }
        else if (angle == 180)
        {
            answer = 4;
        }

        return answer;
    }
}

//짝수의 합
//정수 n이 주어질 때, n이하의 짝수를 모두 더한 값을 return 하도록 solution 함수를 작성해주세요.
public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                answer += i;
            }
        }
        return answer;
    }
}


//배열의 평균값
//정수 배열 numbers가 매개변수로 주어집니다. numbers의 원소의 평균값을 return하도록 solution 함수를 완성해주세요.

public class Solution
{
    public double solution(int[] numbers)
    {
        double answer = 0;
        int num = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            num += numbers[i];
        }

        answer = (double)num / (double)numbers.Length;
        return answer;
    }
}





// 짝수와 홀수
//문제 설명
//정수 num이 짝수일 경우 "Even"을 반환하고 홀수인 경우 "Odd"를 반환하는 함수, solution을 완성해주세요.

//제한 조건
//num은 int 범위의 정수입니다.
//0은 짝수입니다.


public class Solution
{

    // solution 함수는 정수형 매개변수 num을 받아 문자열을 반환. 타입은 string
    public string solution(int num)
    {

        // 문자열을 저장할 변수 answer를 선언하고 빈 문자열로 초기화
        string answer = "";

        if (num % 2 == 0)
        {
            answer = "Even";
        }
        else
        {
            answer = "Odd";
        }

        return answer;
    }
}



//평균 구하기

//문제 설명
//정수를 담고 있는 배열 arr의 평균값을 return하는 함수, solution을 완성해보세요.

//제한사항
//arr은 길이 1 이상, 100 이하인 배열입니다.
//arr의 원소는 -10,000 이상 10,000 이하인 정수입니다.

public class Solution
{
    public double solution(int[] arr)
    {
        double answer = 0;


        // 배열의 모든 요소를 더하는 반복문
        for (int i = 0; i < arr.Length; i++)
        {
            answer += arr[i];
        }

        //배열의 길이로 나누어 평균값 계산
        answer /= arr.Length;

        //평균값 반환
        return answer;
    }
}



//자릿수 더하기
//문제 설명
//자연수 N이 주어지면, N의 각 자릿수의 합을 구해서 return 하는 solution 함수를 만들어 주세요.
//예를들어 N = 123이면 1 + 2 + 3 = 6을 return 하면 됩니다.

//제한사항
//N의 범위 : 100,000,000 이하의 자연수

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        //정수 n을 String형으로 변환 후 CharArray로 변환
        char[] arr = n.ToString().ToCharArray();

        //반복문을 통해 각 해당 문자를 int형으로 바꾸어 answer에 더해줌.
        foreach (char a in arr)
        {
            answer += System.Convert.ToInt32(a.ToString());
        }
        return answer;
    }
}


//약수의 합

//문제 설명
//정수 n을 입력받아 n의 약수를 모두 더한 값을 리턴하는 함수, solution을 완성해주세요.

//제한 사항
//n은 0 이상 3000이하인 정수입니다.

public class Solution
{
    public int solution(int n)
    {
        int answer = 0;

        // i가 1부터 n/2값이 될때까지 증가시키면서 for문 반복
        for (int i = 1; i <= n / 2; i++)
        {
            if (n % i == 0)
            {
                // 나눠떨어지면 약수이므로 곧장 answer에 더해줌
                answer += i;
            }
        }
        // 마지막으로 자기자신 n을 더해주면서 리턴한다.
        return answer + n;
    }
}


//나머지가 1이 되는 수 찾기

//문제 설명
//자연수 n이 매개변수로 주어집니다. n을 x로 나눈 나머지가 1이 되도록 하는 가장 작은 자연수 x를 return 하도록 solution 함수를 완성해주세요. 답이 항상 존재함은 증명될 수 있습니다.

//제한사항
//3 ≤ n ≤ 1,000,000


public class Solution
{
    public int solution(int n)
    {
        int answer = 0;  // 반환할 값을 저장하는 변수, 초기값은 0

        // 2부터 n-1까지의 수를 반복
        for (int x = 2; x < n; x++)
        {
            // n을 x로 나눈 나머지가 1인지 확인
            if (n % x == 1)
            {
                answer = x;  // 나머지가 1이라면 answer에 현재의 수 x를 저장
                break;      // 찾았으므로 반복문 종료
            }
        }

        return answer;  // 찾은 값을 반환
    }
}