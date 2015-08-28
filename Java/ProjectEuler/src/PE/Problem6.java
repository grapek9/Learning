package PE;

/**
 * Created by Daniel on 2015-08-28.
 */
public class Problem6 {
    public static void main(String[] args){
        int value = 100;
        System.out.println(sumOfSquares(value));
        System.out.println(squareOfSum(value));
        System.out.println(squareOfSum(value)-sumOfSquares(value));
    }
    public static int sumOfSquares(int number){
        int value = 0;
        for(int i=1;i<=number;i++){
            value+=power(i);
        }
        return value ;
    }
    public static int squareOfSum(int number){
        int value = 0;
        for(int i = 1; i<=number;i++){
           value+=i;
        }
        return power(value);
    }
    public static int power(int number){return number*number;}
}
