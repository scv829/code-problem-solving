import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);

        String S= scanner.next();
        int[] result = new int[26];

        for(int i = 0; i < S.length(); i++){
            int index = (int)S.charAt(i) - (int)'a';
            result[index] += 1;
        }

        for (int i = 0 ; i < 26; i++) System.out.print(result[i] + " ");

    }
}

