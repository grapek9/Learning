package PE;

import java.math.BigInteger;

/**
 * Created by Daniel on 2015-08-24.
 */
public class Problem3 {
    public static void main(String[] Args){
        long maxFactor = 0 ;
        long iterator = 1;
        long value = 600851475143L;
        do{
            iterator++;
            if(value%iterator==0){
                if(isPrime(iterator)==true){
                    maxFactor=iterator;
                }
            }
            if(iterator%100000000==0){System.out.println(iterator/100000000+"*100000000");}
        }while(iterator < 600851475143L);
        System.out.println(maxFactor);
    }
    public static boolean isPrime(long number){

        for(long i = 2 ; i<(number/2)+1 ;i++){
            if(number%i==0) return false;
        }
        return true;
    }
}
