import java.util.Scanner;

public class Main {

	static int Ycost(int[] costArr) {
		int total = 0;
		for (int i : costArr) {
				total += 1 + (i / 30);
		}
		return total * 10;
	}
	static int Mcost(int[] costArr) {
		int total = 0;
		for (int i : costArr) {
			total += 1 + (i / 60);
		}
		return total * 15;
	}

	public static void main(String[] args) {
		Scanner s = new Scanner(System.in);
		int N = s.nextInt();
		int[] costArr = new int[N];

		for (int i = 0; i < N; i++) {
			costArr[i] = s.nextInt();
		}
		int yCost = Ycost(costArr);
		int mCost = Mcost(costArr);

		if (yCost == mCost)
			System.out.println("Y M " + yCost);
		else if (yCost > mCost)
			System.out.println("M " + mCost);
		else
			System.out.println("Y " + yCost);
	}

}