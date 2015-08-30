package PE;

/**
 * Created by Daniel on 2015-08-30.
 */
public class Problem10 {
    public static void main(String[] args){
        System.out.println(sumOfPrimes(2000000));
    }
    public static int sumOfPrimes(int range){
        int result =0;
        for(int i =2;i<range;i++){
            if(isPrime(i)){result+=i; System.out.println(i);}
        }
        return result;
    }
    public static boolean isPrime(int number){
        for(int i=2;i<number;i++){
            if(number%i==0)return false;
        }
        return true;
    }
}
