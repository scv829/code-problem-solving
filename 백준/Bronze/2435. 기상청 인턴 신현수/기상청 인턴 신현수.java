import java.util.Arrays;
import java.util.Scanner;

public class Main {


	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);

		int N = s.nextInt(); int K = s.nextInt();
		Integer[] tem = new Integer[N];
		int[] result = new int[N-K+1];

		for (int i = 0 ; i < N; i++){
			tem[i]= s.nextInt();
		}

		for(int i = 0 ; i < result.length; i++){
			for(int j = 0; j < K; j++){
				result[i] += tem[i+j];
			}
		}
		System.out.println(Arrays.stream(result).max().getAsInt());
	}
}