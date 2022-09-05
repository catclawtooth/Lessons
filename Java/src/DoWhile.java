import java.util.Scanner;

public class DoWhile {
    public static void main(String[] args) {
        Scanner theScaner = new Scanner(System.in);
        /*System.out.println("Enter a number 5");         // Первая запись -
        int namber5 = theScaner.nextInt();              // кода
        while (namber5 != 5) {
            System.out.println("Enter a number 5!!!");  // Повторение -
            namber5 = theScaner.nextInt();              // кода
        }
        System.out.println("You entered the number 5. Congratulations!");*/

        //  Сокращаем!

        int namber5;
        do {
            System.out.println("Enter a number 5!!!");
            namber5 = theScaner.nextInt();
        }while (namber5 != 5);   //  Если <true>, то выполняем тело <do>
                                 //  Если <false>, то продолжаем выполнение программы
        System.out.println("You entered the number 5. Congratulations!");
        }

}
