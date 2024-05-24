import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int[] result = new int[5];
		for (int i = 0; i < 5; i++) {
			result[i] = s.nextInt();
		}
		result = Arrays.stream(result).sorted().toArray();
		System.out.println(Arrays.stream(result).sum() / 5);
		System.out.println(result[2]);
	}
}