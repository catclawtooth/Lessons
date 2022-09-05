public class For {
    public static void main(String[] args) {
                                            //Цикл выполняется -       Что делаем с переменной каждый раз -
             //Стартовая позиция счетчика    - до тех пор пока          - проходя через цикл
        for(          int i = 0;                    i<=10;               i = i + 1 /*  'i++'  */){
            System.out.println("Hello " + i);     // Пока 'i<=10' <true> выполняется тело цикла ('Hello 0..10')
                                                  // Если 'i<=10' <false> выходим из цикла
        }
    }
}
