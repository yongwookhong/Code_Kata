using System;
using static Solution;

//코드카타 코드들의 모음 그냥 여기에 붙이고 있음 하나의 메모장처럼.. ㅋㅋ


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


//x만큼 간격이 있는 n개의 숫자


//문제 설명
//함수 solution은 정수 x와 자연수 n을 입력 받아, x부터 시작해 x씩 증가하는 숫자를 n개 지니는 리스트를 리턴해야 합니다. 다음 제한 조건을 보고, 조건을 만족하는 함수, solution을 완성해주세요.

//제한 조건
//x는 -10000000 이상, 10000000 이하인 정수입니다.
//n은 1000 이하인 자연수입니다.



public class Solution
{
    public long[] solution(int x, int n)
    {
        long[] answer = new long[n];
        long temp = 0;

        for (int i = 0; i < n; i++)
        {
            temp += x;
            answer[i] = temp;
        }
        return answer;
    }
}

// 자연수 뒤집어 배열로 만들기
//문제 설명
//자연수 n을 뒤집어 각 자리 숫자를 원소로 가지는 배열 형태로 리턴해주세요. 예를들어 n이 12345이면 [5,4,3,2,1] 을 리턴합니다.

//제한 조건
//n은 10,000,000,000이하인 자연수입니다.


using System;
using System.Linq;

public class Solution
{
    // 입력된 정수 n의 각 자릿수를 배열로 반환하는 함수
    public int[] solution(long n)
    {
        // 입력된 정수 n을 문자열로 변환하여 저장
        string str = n.ToString();

        // 반환될 정수 배열을 생성 (자릿수만큼의 크기)
        int[] answer = new int[str.Length];

        // 각 자릿수를 배열에 저장하는 반복문
        for (int i = 0; i < str.Length; i++)
        {
            // 각 자릿수를 문자열로 변환하고 정수로 파싱하여 배열에 저장
            answer[i] = int.Parse(str[i].ToString());
        }

        // 배열을 거꾸로 뒤집음
        Array.Reverse(answer);

        // 최종 결과를 반환
        return answer;
    }
}


// 문자열을 정수로 바꾸기
//문제 설명
//문자열 s를 숫자로 변환한 결과를 반환하는 함수, solution을 완성하세요.

//제한 조건
//s의 길이는 1 이상 5이하입니다.
//s의 맨앞에는 부호(+, -)가 올 수 있습니다.
//s는 부호와 숫자로만 이루어져있습니다.
//s는 "0"으로 시작하지 않습니다.


public class Solution
{
    // 문자열을 정수로 변환하여 반환하는 함수
    public int solution(string s)
    {
        // 문자열 s를 정수로 변환
        int answer = int.Parse(s);

        // 변환된 정수를 반환
        return answer;
    }
}



//정수의 제곱근 판별
//문제 설명
//임의의 양의 정수 n에 대해, n이 어떤 양의 정수 x의 제곱인지 아닌지 판단하려 합니다.
//n이 양의 정수 x의 제곱이라면 x+1의 제곱을 리턴하고, n이 양의 정수 x의 제곱이 아니라면 -1을 리턴하는 함수를 완성하세요.

//제한 사항
//n은 1이상, 50000000000000 이하인 양의 정수입니다.


using System;

public class Solution
{
    // 정수 n을 입력으로 받아, 어떤 양의 정수 x의 제곱으로 표현될 수 있는지 확인하는 함수
    public long solution(long n)
    {
        // 입력 값 n의 제곱근을 구함
        long x = (long)Math.Sqrt(n);

        // x의 제곱이 입력 값 n과 일치하는지 확인하고, 일치하면 (x+1)의 제곱 반환, 아니면 -1 반환
        return (x * x == n) ? (x + 1) * (x + 1) : -1;
    }
}






//정수 내림차순으로 배치하기

// 문제 설명
//함수 solution은 정수 n을 매개변수로 입력받습니다. n의 각 자릿수를 큰것부터 작은 순으로 정렬한 새로운 정수를 리턴해주세요. 예를들어 n이 118372면 873211을 리턴하면 됩니다.

//제한 조건
//n은 1이상 8000000000 이하인 자연수입니다.
 


using System;
using System.Linq;

public class Solution
{
    // solution 함수 정의
    public long solution(long n)
    {
        // 1. long 타입의 숫자를 문자열로 변환하고, 문자 배열로 변환
        char[] arr = n.ToString().ToCharArray();

        // 2. 문자 배열을 오름차순으로 정렬
        Array.Sort(arr);

        // 3. 정렬된 배열을 뒤집어서 내림차순으로 만듦
        Array.Reverse(arr);

        // 4. 문자 배열을 다시 문자열로 변환하고, 이를 long으로 변환
        long answer = Convert.ToInt64(new string(arr));

        // 5. 최종 결과 반환
        return answer;
    }
}



//하샤드 수
//문제 설명
//양의 정수 x가 하샤드 수이려면 x의 자릿수의 합으로 x가 나누어져야 합니다. 예를 들어 18의 자릿수 합은 1+8=9이고, 18은 9로 나누어 떨어지므로 18은 하샤드 수입니다. 자연수 x를 입력받아 x가 하샤드 수인지 아닌지 검사하는 함수, solution을 완성해주세요.

//제한 조건
//x는 1 이상, 10000 이하인 정수입니다.

using System;

public class Solution
{
    // 정수 x를 입력으로 받아 각 자리 숫자의 합으로 나누어지는지 확인하는 메서드
    public bool solution(int x)
    {
        // 정수 x를 문자열로 변환한다. 왜냐하면 문자열로 변환하면 각 자릿수에 쉽게 접근할 수 있기 때문
        string temp = x.ToString();
        // 각 자릿수의 합을 저장할 변수
        int sum = 0;
        // 문자열을 순회하며 각 자리 숫자의 합을 계산
        for (int i = 0; i < temp.Length; i++)
        {
            // Char.GetNumericValue 메서드를 사용하여 문자를 숫자로 변환하고 합산
            // 여기서 중요한 개념은 'char'를 'int'로 변환하는 것이다. 예를 들어, '5'를 정수 5로 바꿈
            sum += (int)Char.GetNumericValue(temp[i]);
        }
        // x가 자릿수 합으로 나눠떨어지면 참, 아니면 거짓
        // 여기서 '?'는 "만약"이라는 의미
        // x % sum == 0 이 참이면 true를, 그렇지 않으면 false를 answer 변수에 저장
        bool answer = x % sum == 0 ? true : false;

        // 최종 결과 반환
        return answer;
    }
}


//두 정수 사이의 합
//문제 설명
//두 정수 a, b가 주어졌을 때 a와 b 사이에 속한 모든 정수의 합을 리턴하는 함수, solution을 완성하세요.
//예를 들어 a = 3, b = 5인 경우, 3 + 4 + 5 = 12이므로 12를 리턴합니다.

//제한 조건
//a와 b가 같은 경우는 둘 중 아무 수나 리턴하세요.
//a와 b는 -10,000,000 이상 10,000,000 이하인 정수입니다.
//a와 b의 대소관계는 정해져있지 않습니다.

public class Solution
{
    public long solution(int a, int b)
    {
        long answer = 0;
        //a가 b보다 작으면 a부터 b까지 1씩 더한 값 answer에 더함
        if (a < b)
        {
            for (int i = a; i <= b; i++)
            {
                answer += i;
            }
        }
        //a가 b보다 크면 a부터 b까지 1씩 뺀 값 answer에 더함
        else
        {
            for (int i = a; i >= b; i--)
            {
                answer += i;
            }
        }


        //콜라츠 추측
        //문제 설명
        //1937년 Collatz란 사람에 의해 제기된 이 추측은, 주어진 수가 1이 될 때까지 다음 작업을 반복하면, 모든 수를 1로 만들 수 있다는 추측입니다.작업은 다음과 같습니다.

        //1 - 1.입력된 수가 짝수라면 2로 나눕니다.
        //1 - 2.입력된 수가 홀수라면 3을 곱하고 1을 더합니다.
        //결과로 나온 수에 같은 작업을 1이 될 때까지 반복합니다.
        //예를 들어, 주어진 수가 6이라면 6 → 3 → 10 → 5 → 16 → 8 → 4 → 2 → 1 이 되어 총 8번 만에 1이 됩니다. 위 작업을 몇 번이나 반복해야 하는지 반환하는 함수, solution을 완성해 주세요.
        //단, 주어진 수가 1인 경우에는 0을, 작업을 500번 반복할 때까지 1이 되지 않는다면 –1을 반환해 주세요.
        //제한 사항
        //입력된 수, num은 1 이상 8,000,000 미만인 정수입니다.


        public class Solution
    {
        public int solution(long num)
        {
            if (num == 1)
            {
                return 0;
            }

            for (int i = 0; i <= 500; i++)
            { // 500번의 반복 후에도 결과를 찾지 못하면 종료
                if (num == 1)
                {
                    return i; // 1이면 반복 횟수를 반환
                }
                else if (num % 2 == 0)
                { // 짝수인 경우
                    num /= 2; // 숫자를 2로 나눔
                }
                else
                { // 홀수인 경우
                    num = num * 3 + 1; // 숫자를 3배하고 1을 더함
                }
            }
            return -1; // 500번의 반복 후에도 결과를 찾지 못하면 -1을 반환
        }
    }



    //서울에서 김서방 찾기
    //    문제 설명
    //String형 배열 seoul의 element중 "Kim"의 위치 x를 찾아, "김서방은 x에 있다"는 String을 반환하는 함수, solution을 완성하세요.seoul에 "Kim"은 오직 한 번만 나타나며 잘못된 값이 입력되는 경우는 없습니다.

    //제한 사항
    //seoul은 길이 1 이상, 1000 이하인 배열입니다.
    //seoul의 원소는 길이 1 이상, 20 이하인 문자열입니다.
    //"Kim"은 반드시 seoul 안에 포함되어 있습니다.

    public class Solution
    {
        // solution 함수 정의
        public string solution(string[] seoul)
        {
            // 반환할 결과 문자열을 초기화
            string answer = "";

            // 문자열 배열을 반복하여 "Kim"이 있는지 확인
            for (int i = 0; i < seoul.Length; i++)
            {
                // 만약 해당 문자열이 "Kim"이면
                if (seoul[i] == "Kim")
                {
                    // 결과 문자열을 설정하고 반복문을 종료
                    answer = "김서방은 " + i + "에 있다";
                    break;
                }
            }
            // 결과 반환
            return answer;
        }
    }



    // 나누어 떨어지는 숫자 배열



//    문제 설명
//array의 각 element 중 divisor로 나누어 떨어지는 값을 오름차순으로 정렬한 배열을 반환하는 함수, solution을 작성해주세요.
//divisor로 나누어 떨어지는 element가 하나도 없다면 배열에 -1을 담아 반환하세요.

//제한사항
//arr은 자연수를 담은 배열입니다.
//정수 i, j에 대해 i ≠ j 이면 arr[i] ≠ arr[j] 입니다.
//divisor는 자연수입니다.
//array는 길이 1 이상인 배열입니다.


    using System.Collections.Generic;

public class Solution
{
    // 주어진 배열(arr)에서 divisor로 나누어 떨어지는 숫자들을 찾아 반환합니다.
    public int[] solution(int[] arr, int divisor)
    {
        // 결과를 저장할 리스트 생성
        List<int> result = new List<int>();

        // 배열을 순회하면서 나누어 떨어지는 숫자를 찾아 결과 리스트에 추가
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % divisor == 0)
            {
                result.Add(arr[i]);
            }
        }

        // 결과 리스트가 비어있으면 -1을 담은 배열을 반환
        if (result.Count == 0)
        {
            return new int[] { -1 };
        }

        // 결과 리스트를 정렬
        result.Sort();

        // 정렬된 결과를 배열로 변환하여 반환
        return result.ToArray();
    }
}



//# 음양 더하기


//## 문제 설명

//int형 배열(absolutes)이 있고 이 int형 배열(absolutes)의 길이만큼 bool형 배열(signs)이 있습니다.

//signs[i] 가 true면 absolutes[i] 은 양수, false면 absolutes[i] 은 음수입니다.

//부호에 맞게 absolutes의 합을 구해서 반환하는 문제입니다.

//## 문제 풀이

//absolutes와 signs의 길이는 동일하니 반복문을 돌리면 풀 수 있습니다.

//signs[i] 가 true면 answer에 absolutes[i] 를 더하고,
//signs[i]가 false면 answer에 absolutes[i] 를 빼면

//부호에 맞는 absolutes의 합을 구할 수 있습니다.



using System;

public class Solution
{
    // 주어진 정수 배열 absolutes와 부울 배열 signs를 받아서
    // 절댓값을 구하고, signs 배열에 따라 부호를 적용하여 결과를 반환하는 함수
    public int solution(int[] absolutes, bool[] signs)
    {
        int answer = 0; // 결과 값을 저장할 변수

        // absolutes 배열의 각 원소를 반복하여 처리
        for (int i = 0; i < absolutes.Length; i++)
        {
            // signs[i]가 참(true)인 경우 해당 원소 그대로 더함
            // signs[i]가 거짓(false)인 경우 해당 원소에 -1을 곱해서 음수로 변환하여 더함
            answer += absolutes[i] = signs[i] ? absolutes[i] : absolutes[i] * -1;
        }

        // 최종 결과 반환
        return answer;
    }


}

//핸드폰 번호 가리기

//문제 설명
//프로그래머스 모바일은 개인정보 보호를 위해 고지서를 보낼 때 고객들의 전화번호의 일부를 가립니다.
//전화번호가 문자열 phone_number로 주어졌을 때, 전화번호의 뒷 4자리를 제외한 나머지 숫자를 전부 *으로 가린 문자열을 리턴하는 함수, solution을 완성해주세요.

//제한 조건
//phone_number는 길이 4 이상, 20이하인 문자열입니다.

public class Solution
{
    // solution 메서드는 문자열 phone_number를 받아들여서 해당 문자열을 가공하여 반환
    public string solution(string phone_number)
    {
        // 결과를 저장할 문자열 변수를 초기화
        string answer = "";

        // 맨 뒤의 4자리를 추출하여 temp_str에 저장
        string temp_str = phone_number.Substring(phone_number.Length - 4, 4);

        // 전화번호에서 맨 뒤의 4자리를 제외한 앞부분에 '*'를 추가하여 answer에 저장
        for (int i = 0; i < phone_number.Length - 4; ++i)
        {
            answer += "*";
        }

        // 앞부분에 '*'로 가려진 전화번호와 추출한 마지막 4자리를 합쳐 최종 결과를 만듦
        answer += temp_str;

        // 가공된 전화번호를 반환
        return answer;
    }
}




// C# 없는 숫자 더하기

//문제 설명
//제한사항
//풀이
//문제 설명
//0부터 9까지의 숫자 중 일부가 들어있는 정수 배열 numbers가 매개변수로 주어집니다. numbers에서 찾을 수 없는 0부터 9까지의 숫자를 모두 찾아 더한 수를 return 하도록 solution 함수를 완성해주세요.

//제한사항
//1 ≤ numbers의 길이 ≤ 9
//0 ≤ numbers의 모든 원소 ≤ 9
//numbers의 모든 원소는 서로 다릅니다.


using System; // C# 표준 라이브러리를 사용하기 위한 선언
using System.Linq; // LINQ 기능을 사용하기 위한 선언

public class Solution // Solution 클래스 정의
{
    public int solution(int[] numbers) // solution 메서드 정의, int 배열을 입력으로 받고 정수를 반환
    {
        int answer = 0; // 정수형 변수 answer를 선언하고 0으로 초기화
        // 0부터 9까지의 숫자의 합을 answer에 더함
        for (int i = 0; i <= 9; i++)
        {
            answer += i;
        }
        // numbers 배열의 모든 요소의 합을 answer에서 빼기
        answer -= numbers.Sum();
        return answer; // 결과 반환
    }
}





// 제일 작은수 제거하기
//문제 설명
//정수를 저장한 배열, arr 에서 가장 작은 수를 제거한 배열을 리턴하는 함수, solution을 완성해주세요. 단, 리턴하려는 배열이 빈 배열인 경우엔 배열에 -1을 채워 리턴하세요. 예를들어 arr이 [4,3,2,1] 인 경우는[4, 3, 2]를 리턴 하고, [10]면 [-1] 을 리턴 합니다.

//제한 조건
//arr은 길이 1 이상인 배열입니다.
//인덱스 i, j에 대해 i ≠ j이면 arr[i] ≠ arr[j] 입니다.


using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int[] solution(int[] arr)
    {
        // 주어진 배열을 리스트로 변환
        List<int> arr_list = new List<int>(arr);

        // 배열에서 최솟값을 찾기
        int min = arr.Min();

        // 리스트에서 최솟값을 모두 제거
        arr_list.RemoveAll(num => num == min);

        // 리스트가 비어있다면, 최솟값만으로 구성된 배열을 반환하기 위해 -1을 추가
        if (arr_list.Count == 0)
        {
            arr_list.Add(-1);
        }
        // 최종적으로 리스트를 배열로 변환하여 반환
        return arr_list.ToArray();
    }
}


 //가운데 글자 가져오기
//문제 설명
//단어 s의 가운데 글자를 반환하는 함수, solution을 만들어 보세요. 단어의 길이가 짝수라면 가운데 두글자를 반환하면 됩니다.

//제한사항
//s는 길이가 1 이상, 100이하인 스트링입니다.


public class Solution
{
    public string solution(string s)
    {
        int num2 = (s.Length + 1) % 2;
        // 주어진 문자열의 길이에 1을 더한 후 2로 나눈 나머지를 계산하여 홀수/짝수 여부를 판단
        int num1 = (s.Length / 2) - num2; // 가운데 글자의 시작 인덱스를 계산

        return s.Substring(num1, 1 + num2); // 가운데 글자(들)를 반환
    }
}


//수박수박수박수?

//문제 설명
//길이가 n이고, "수박수박수박수...."와 같은 패턴을 유지하는 문자열을 리턴하는 함수, solution을 완성하세요. 예를들어 n이 4이면 "수박수박"을 리턴하고 3이라면 "수박수"를 리턴하면 됩니다.

//제한 사항
//n은 길이 10,000이하인 자연수입니다.

//코드풀이


public class Solution
{
    // solution 메서드: 정수 n을 입력으로 받아 "수박" 패턴의 문자열을 반환합니다.
    public string solution(int n)
    {
        // 결과 문자열을 저장할 변수 초기화
        string answer = "";
        // "수"와 "박" 문자를 배열에 저장
        char[] watermelon = { '수', '박' };

        // n번 반복하면서 문자열 생성
        for (int i = 0; i < n; i++)
        {
            // 인덱스 i를 2로 나눈 나머지를 사용하여 "수"와 "박"을 번갈아가며 추가
            answer += watermelon[i % 2];
        }

        // 결과 문자열 반환
        return answer;
    }
}


// 내적 
//문제 설명
//길이가 같은 두 1차원 정수 배열 a, b가 매개변수로 주어집니다. a와 b의 내적을 return 하도록 solution 함수를 완성해주세요.

//이때, a와 b의 내적은 a[0] * b[0] + a[1] * b[1] + ... +a[n - 1] * b[n - 1] 입니다. (n은 a, b의 길이)

//제한사항
//a, b의 길이는 1 이상 1,000 이하입니다.
//a, b의 모든 수는 -1,000 이상 1,000 이하입니다.


using System;

public class Solution
{
    public int solution(int[] a, int[] b)
    {
        // 결과를 저장할 변수 초기화
        int answer = 1234567890;
        // 요소들을 더해나갈 변수 초기화
        int sum = 0;
        // 두 배열의 각 요소들을 곱하여 누적한 후 저장
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i] * b[i];
        }

        answer = sum;
        return answer;
    }
}




//문제 설명
//두 정수 left와 right가 매개변수로 주어집니다. left부터 right까지의 모든 수들 중에서, 약수의 개수가 짝수인 수는 더하고, 약수의 개수가 홀수인 수는 뺀 수를 return 하도록 solution 함수를 완성해주세요.

//제한사항
//1 ≤ left ≤ right ≤ 1,000




using System;

public class Solution
{
    public int solution(int left, int right)
    {
        int answer = 0;
        // left부터 right까지 모든 정수에 대해 반복합니다.
        for (int i = left; i <= right; i++)
        {
            int cnt = 0; // i의 약수의 개수를 저장할 변수입니다.
            // 1부터 i까지 모든 수에 대해 반복하여 i의 약수를 찾습니다.
            for (int j = 1; j <= i; j++) { if (i % j == 0) { cnt++; } } // i를 j로 나누어 떨어지면(약수면) cnt를 1 증가시킵니다.
            // 약수의 개수(cnt)가 짝수인 경우 answer에 i를 더하고, 홀수인 경우 answer에서 i를 뺍니다.
            if (cnt % 2 == 0) { answer += i; }
            else { answer -= i; }
        }
        return answer; // 최종 계산된 answer 값을 반환합니다.
    }
}