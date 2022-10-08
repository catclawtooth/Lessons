public class While {
    public static void main(String[] args) {
        /*int a = 4;
        boolean bool = a>5;            // <false>
        System.out.println(bool);      // Выводим в консоль <false>*/

        /*int a = 6;
        while (a>5) {                            //<true>
            System.out.println("Hello");         // если <true> -> цикл бесконечно выполняет 'Hello'
        }                                        // если <false> -> цикл не выполняется*/

        int a = 0;
        while (a<=5) {                              //<true>
            System.out.println("Hello " + a);       //Вывод в консоль 'Hello 0'
            a = a + 1;                              //Увеличиваем значение 'а' на еденицу и повторяем цикл -
        }                                           // - пока условие не станет <false> и выходим из цикла
    }
}
