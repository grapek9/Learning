package NextPrime;
import java.util.Scanner;

/**
 * Created by Daniel on 2014-12-10.
 */
public class nextprime {
    public static void main(String args[]){
        System.out.println("Next Prime Generator");
        Scanner decision= new Scanner(System.in);
        int digit=1;
        String choice="y";
        do{
            do{
                digit++;
            }while(isPrime(digit)); // using function isPrime to check if digit is prime, when recive false then breaks, and that means he hit prime number
            System.out.println("Number "+digit+" is a prime nubmer"); // simple println
            System.out.println("Continue ?? y/n"); // ask user to continue
            choice=decision.nextLine(); // get user answer
        }while(choice.equals("y"));  // keep going when user press y
    }
    public static boolean isPrime(int digit){
        boolean answer=true;
        int counter=0;
       for(int i=1;i<=digit;i++) // counter increases when the reminder is 0
       {
           if(digit%i==0){
              counter+=1;
           }
       }
        if(counter<=2) answer=false; // prime numbers will have only 2 divisor, 1 and itself

    return answer; //returning fallse will break do-while that increase digit
    }
}
