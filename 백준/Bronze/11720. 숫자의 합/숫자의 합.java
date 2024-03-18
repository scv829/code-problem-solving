import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        int N, result= 0;
        String num = "";
        Scanner scanner = new Scanner(System.in);
        N = scanner.nextInt();
        num = scanner.next();
        for(int i = 0; i < N; i++){
            result += Integer.parseInt(String.valueOf(num.charAt(i)));
        }
        System.out.println(result);
    }
}