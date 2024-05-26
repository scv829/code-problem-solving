import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);

        int N = scanner.nextInt();

        String number = String.valueOf(N);

        int[] arr = new int[9];
        int sameCount = 0;

        for(int i = 0; i < number.length(); i++){
            int index = (int)number.charAt(i) - (int)'0';
            if( index == 9 || index == 6 ) sameCount += 1;
            else arr[index] +=1;
        }

        int result = Math.max( Arrays.stream(arr).max().getAsInt(), (sameCount % 2 == 0 ? (sameCount / 2): (sameCount /2) + 1) );

        System.out.print(result);
    }
}

