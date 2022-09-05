import java.util.Scanner;

public class Break {
    public static void main(String[] args) {
        System.out.println("Entered number");
        Scanner theScaner = new Scanner(System.in);
        int i, namber;
        i = 0;
        namber = theScaner.nextInt();   // Допустим ввели чило '5'
        while (i <= namber) {           // <true>, идем в тело
            if (namber == 0) {          // <false> Проверка на ввод '0'. Если <true>, то прекращаем программу
                System.out.println("0");
                break;                  // Оператор прекращает выполнение программы (цикла)
            }
            System.out.println(i);
            i++;
            if (i >= namber) {  // <false> возвращаемся в начало цикла. При достижении <true> прекращаем программу
                break;
            }
        }

    }
}
