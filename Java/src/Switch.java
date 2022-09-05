import java.util.Scanner;

public class Switch {
    public static void main(String[] args) {
        Scanner theScaner = new Scanner(System.in);
                int a = theScaner.nextInt();
        switch (a) {                          // Проверяем 'a' со значениями кейсов
            case 0:
                System.out.println("0");
                break;
            case 5:
                System.out.println("5");       // Выполняем тот кейс, который совпадает со значением 'a'
                break;
            case 8:
                System.out.println("8");
                break;
            default:   // Если ни один кейс не совпал то выполняем 'default' (не обязательно его использовать)
                System.out.println("Defoult");
        }
    }
}
