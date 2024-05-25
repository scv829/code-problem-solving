import java.util.Scanner;

public class Main {

	static final int N = 10;

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int[] cards = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};

		for (int i = 0; i < N; i++) {
			int a = s.nextInt() - 1;
			int b = s.nextInt() - 1;

			while (b > a) {
				int temp = cards[a];
				cards[a] = cards[b];
				cards[b] = temp;
				a++;
				b--;
			}
		}

		for (int card : cards)
			System.out.print(card + " ");
	}
}
