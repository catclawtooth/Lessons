public class If {
    public static void main(String[] args) {
        int data = 15;
        if(data == 10){                          // Если <true>, выполням тело цикла
            System.out.println("Equals 10!");    // Если <false>, цикл не выполняется (выполняется <else_if>...)
        }else if (data < 10){                    // Все условия <false>, в итоге выполняем <else>
            System.out.println("Less than 10!");
        }else{
            System.out.println("Doesn't fit any condition");  // 'Ни одно из условий не выполнено'
        }          // Если оба условия <true>, то будет выполнено первое условие по порядку, -
                   // - остальные условия не проверяются
    }
}
