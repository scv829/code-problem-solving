import java.util.Arrays;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int[] result = new int[9];
		int gap;
		for (int i = 0; i < 9; i++) {
			result[i] = s.nextInt();
		}
		result = Arrays.stream(result).sorted().toArray();
		gap = Arrays.stream(result).sum() - 100;
		for (int i = result.length - 1; i > 0; i--) {
			for (int j = i - 1; j >= 0; j--) {
				if (gap == result[i] + result[j]) {
					gap = 0;
					result[i] = result[j] = -1;
					break;
				}
			}
			if (gap == 0)
				break;
		}
		for (int i : result) {
			if (i != -1)
				System.out.println(i);
		}
	}
}