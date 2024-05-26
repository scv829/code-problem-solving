import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);

        int a = scanner.nextInt(); int b = scanner.nextInt(); int c = scanner.nextInt();
        String total = String.valueOf(a * b * c);

        int[] result = new int[10];
        for (int i = 0; i < total.length(); i++){
            result[ (int)total.charAt(i) - (int)'0' ] += 1;
        }

        for(int i : result) System.out.println(i);

    }
}

