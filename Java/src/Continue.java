public class Continue {
    public static void main(String[] args) {
        for (int i = 0; i <= 5; i++) {
            if (i%2 == 0) {     // % - остаток от деления. Когда <true> - входим в цикл, когда <false> нет.
                continue;       // Оператор возвращает к началу программы (цикла)
            }
            System.out.println("нечетное" + i);
        }
    }
}
