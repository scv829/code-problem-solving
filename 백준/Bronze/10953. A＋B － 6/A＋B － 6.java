import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        int a,b,num;
        Scanner scanner = new Scanner(System.in);
        num = scanner.nextInt();
        for (int i = 0; i < num; i++){
            String line = scanner.next();
            a = Integer.parseInt(String.valueOf(line.charAt(0))) ;
            b = Integer.parseInt(String.valueOf(line.charAt(2)));
            System.out.println(a+b);
        }
    }
}