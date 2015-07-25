package NthDigit;
import java.util.Scanner;

/**
 * Created by Daniel on 2014-12-10.
 */
public class NthDigit {
    public static void main(String args[]){

        int Digit=0;
        Scanner liczba = new Scanner(System.in);
        Digit = liczba.nextInt();
        System.out.println("lolz"+Digit);
        System.out.println("NthDigitPI");
        printA(Digit);
        char test[]=new char[10];
        test[0]=(char)5.1;
        System.out.println("lozl"+test[0]);
        test[0]=(char)Digit;
        System.out.println("lozl"+test[0]);

    }
    public static void printA(int a){
    System.out.println("le a="+a);
    }
}
