import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);

        int x = scanner.nextInt();

        for(int i = 0; i < x; i++){
            for(int first = 0; first <= i ; first++) System.out.print("*");
            for(int blank = 2 * (x-i-1) ; blank > 0 ; blank--) System.out.print(" ");
            for(int last = 0;  last <= i ; last++) System.out.print("*");
            System.out.println();
        }
        for(int i = x-2; i >= 0; i--){
            for(int first = 0; first <= i ; first++) System.out.print("*");
            for(int blank = 2 * (x-i-1) ; blank > 0 ; blank--) System.out.print(" ");
            for(int last = 0;  last <= i ; last++) System.out.print("*");
            System.out.println();
        }

    }
}