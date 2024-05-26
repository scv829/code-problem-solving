import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);

        int n = scanner.nextInt();
        int[] arr = new int[n];
        int max = n - 1, min = 0 ,result = 0;

        for(int i = 0; i < n; i++){
            arr[i] = scanner.nextInt();
        }
        int x = scanner.nextInt();

        arr = Arrays.stream(arr).sorted().toArray();


        for(int i = arr.length - 1; i >= 0 ; i-- ) if(x < arr[i]) max = i;

        for(int i = max; i >= 0; i--){

            for(int j = min; j < i; j++){
                if( arr[i] + arr[j] == x) { result += 1; min = j; break;}
            }
        }

        System.out.println(result);
    }

}
