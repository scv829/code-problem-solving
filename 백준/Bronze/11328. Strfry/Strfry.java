import java.util.*;

public class Main{
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);

        int N = scanner.nextInt();

        for(int i = 0; i < N ; i++){
            String str1 = scanner.next();
            String str2 = scanner.next();

            String[] strArr = str1.split("");
            ArrayList<String> char1 = new ArrayList<String>(Arrays.asList(strArr));

            while (true){
                if(char1.isEmpty()){ System.out.println("Possible"); break;}
                else if(str2.isEmpty()) { System.out.println("Impossible"); break;}

                String c = String.valueOf(str2.charAt(str2.length()-1));
                if(!char1.remove(c)){ System.out.println("Impossible"); break;}
                str2 = str2.substring(0, str2.length()-1);
            }
        }

    }
}
