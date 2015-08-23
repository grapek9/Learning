package PE;

/**
 * Created by Daniel on 2015-08-23.
 */
public class Problem2 {
    public static void main(String[] args){
        int sum = 0;
        int temp = 0;
        int firstValue=1,secondValue = 1;
        do{
           // System.out.println(secondValue);
            temp  = secondValue;
            secondValue=firstValue+secondValue;
            firstValue=temp;
            if(secondValue%2==0) sum+=secondValue;

        }while(secondValue<4000000);
        System.out.println(sum);
    }
}
