import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);

        int N = scanner.nextInt();
        int K = scanner.nextInt();
        int rooms = 0;

        int[][] students = new int[6][2];

        for(int i = 0; i < N; i++){
            int gender = scanner.nextInt();
            int grade = scanner.nextInt() - 1;

            students[grade][gender] += 1;
        }

        for(int i = 0; i < 6; i++){

            rooms +=  students[i][0] / K + students[i][1] / K;
            if(students[i][0] % K != 0 ) rooms++;
            if(students[i][1] % K != 0 ) rooms++;
        }
        System.out.println(rooms);

    }
}

