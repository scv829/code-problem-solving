import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		long a = s.nextLong(); long b = s.nextLong();
		if(a-b == 0) System.out.println(0);
		else {
			System.out.println(Math.max(b - a, a - b) - 1);
			for (long i = Math.min(a, b) + 1; i < Math.max(a, b); i++)
				System.out.print(i + " ");
		}
	}
}