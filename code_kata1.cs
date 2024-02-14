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