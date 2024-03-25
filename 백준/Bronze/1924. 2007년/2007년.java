import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);

        int x = scanner.nextInt();
        int y = scanner.nextInt();

        int[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        String[] day = { "SUN", "MON", "TUE", "WED", "THU", "FRI", "SAT"};

        for(int i = 0; i < x-1; i++){ y += month[i]; }

        System.out.println(day[ y % 7 ]);
    }
}
