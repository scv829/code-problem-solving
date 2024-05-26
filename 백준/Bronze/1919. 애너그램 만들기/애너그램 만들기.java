import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);

        String str1 = scanner.next();
        String str2 = scanner.next();

        int[] numArr1 = returnToArray(str1);
        int[] numArr2 = returnToArray(str2);;

        int result = 0;

        for(int i = 0; i < 26; i++){
            int max = Math.max(numArr1[i], numArr2[i]);
            int min = Math.min(numArr1[i], numArr2[i]);

            result += max - min;
        }

        System.out.println(result);

    }

    public static int[] returnToArray(String str){
        int[] arr = new int[26];

        for(int i = 0; i < str.length() ; i++){
            int index = (int) str.charAt(i) - (int)'a';
            arr[index] += 1;
        }

        return arr;
    }
}
