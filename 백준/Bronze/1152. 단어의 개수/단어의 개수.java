import java.util.*;

public class Main{
    public static void main(String[] args) {

        Scanner s = new Scanner(System.in);
        String line = s.nextLine();

        if(line.equals(" ")){
            System.out.println(0);
        }
        else {
            line = line.startsWith(" ") ? line.substring(1) : line;
            List<String> result = new ArrayList<>(List.of(line.split(" ")));

            System.out.println(result.size());
        }

    }

}
