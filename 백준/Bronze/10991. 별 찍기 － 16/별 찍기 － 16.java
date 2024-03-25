import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);

        int x = scanner.nextInt();
        for(int i = 0; i < x; i++){
            for(int j = 0; j < x - i-1; j++) System.out.print(" ");
            for(int k = 0; k < (2*i)+1 ; k++) {
                if(k % 2 == 0) System.out.print("*");
                else System.out.print(" ");
            }
            System.out.println();
        }
    }
}

