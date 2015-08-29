package PE;

/**
 * Created by Daniel on 2015-08-29.
 */
public class Problem7 {
    public static void main(String[] args){
        int primeNumber = generateNthPrime(10001);
        System.out.println(primeNumber);
    }
    public static int generateNthPrime(int number){
        int prime=2;
        int counter = 0;
        do{

            if(isPrime(prime)){

                counter++;
            }
            prime++;
        }while(counter!=number);
        return prime;
    }
    public static boolean isPrime(int number){
        for(int i=2;i<number;i++){
            if(number%i==0) return false;
        }
        return true;
    }
}
