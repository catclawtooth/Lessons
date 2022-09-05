import java.util.Scanner;

public class Input {
    public static void main(String[] args) {


        String str = new String("Random string");  /*  new - создается объект класса стринг, но -
              - для <String> этого делать не обязательно т.к <String> глобален */
             // String str = new String("Random string"); == String str = "Random string";     -> true
        System.out.println(str);

        Scanner s = new Scanner(System.in);         /*  Для работы этого класса необходимо его -
              - объявить  в самом начале глобально командой 'import java.util.Scanner;'   */
        System.out.println("Enter something");

        String enterString = s.nextLine();                // Ввод значения класса <String>
        System.out.println("You entered "+ enterString);

        int enterInt = s.nextInt();                       // Ввод значения класса <int>
        System.out.println("You entered "+ enterInt);
    }
}
