import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);
        String s = scanner.nextLine();
        int first = s.length() / 10;
        int end =  s.length() % 10;
        for(int i = 0 ; i < first; i++){
            System.out.println(s.substring(0 + i*10, 10 + i*10 ));
        }
        System.out.println(s.substring(10*first, 10*first + end ));
    }
}
