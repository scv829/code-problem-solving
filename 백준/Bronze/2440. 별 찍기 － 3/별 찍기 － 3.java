import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);

        int x = scanner.nextInt();

        for(int i = 0; i < x; i++){
            for(int j = x - i; j > 0 ; j--) System.out.print("*");
            System.out.println();
        }

    }
}
