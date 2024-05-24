import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		ArrayList<Integer> arr = new ArrayList<Integer>();
		int index = 0;
		for (int i = 0; index < 7; index++) {
			i = s.nextInt();
			if (i % 2 == 1) {
				arr.add(i);
			}
		}
		if (arr.isEmpty()) {
			System.out.println(-1);
		} else {
			int[] result = new int[arr.size()];
			index = 0;
			for (int i : arr)
				result[index++] = i;

			System.out.println(Arrays.stream(result).sum());
			System.out.println(Arrays.stream(result).min().getAsInt());
		}
	}
}