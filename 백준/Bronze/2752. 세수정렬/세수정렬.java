import java.util.Arrays;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);

		int[] arr = new int[3];

		for (int i = 0; i < 3; i++) {
			arr[i] = s.nextInt();
		}
		arr = Arrays.stream(arr).sorted().toArray();
		System.out.println(arr[0] + " " + arr[1] + " " + arr[2]);

	}
}