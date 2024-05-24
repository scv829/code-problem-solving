import static java.util.Arrays.*;

import java.util.Arrays;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);

		int[] arr = new int[4];
		for(int N = 0; N < 3; N++) {
			for (int i = 0; i < 4; i++) {
				arr[i] = s.nextInt();
			}
			switch (Arrays.stream(arr).sum()){
				case 3: System.out.println("A"); break;
				case 2: System.out.println("B"); break;
				case 1: System.out.println("C"); break;
				case 0: System.out.println("D"); break;
				case 4: System.out.println("E"); break;
			}
		}
	}
}