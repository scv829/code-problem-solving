import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);

        int N= scanner.nextInt();

        for(int i = 0; i <= N; i++ ){
            for(int first = 0; first < i; first++) System.out.print(" ");
            for(int middle = 0; middle < (2*N)-(2*i+1); middle++) System.out.print("*");
            System.out.println();
        }
    }
}

