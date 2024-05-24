import java.util.Scanner;

public class Main {

	static Integer[] dp;

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);

		int num = s.nextInt();

		dp = new Integer[num + 1];
		dp[0] = dp[1] = 0;

		System.out.println(cal(num));
	}

	static int cal(int num){
		if ( dp[num] == null ){
			if (num % 6 == 0){
				dp[num] = Math.min(Math.min(cal(num / 3),cal(num / 2) ), cal(num-1)) + 1;
			}
			else if(num % 3 == 0){
				dp[num] = Math.min(cal(num / 3), cal(num-1)) + 1;
			}
			else if(num % 2 == 0){
				dp[num] = Math.min(cal(num / 2), cal(num-1)) + 1;
			}
			else {
				dp[num] = cal(num - 1) + 1;
			}
		}
		return dp[num];
	}
}