package PE;

/**
 * Created by Daniel on 2015-08-27.
 */
public class Problem5 {
    public static void main(String[] args){
        int number = 0;
        do{

            number++;
            System.out.println(number);
        }while(isDivisible(number)!=true);
        System.out.println(number);
    }
    public static boolean isDivisible(int number){
        for(int i = 1; i<=20;i++){
            if(number%i!=0){return false;}
        }
        return true;
    }
}
