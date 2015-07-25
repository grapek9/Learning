/**
 * Created by Daniel on 2015-04-28.
 */
import java.util.Random;
import java.util.Scanner;
public class zad3 {
    public static void main(String args[]){
        Random generator = new Random();
        int seed=generator.nextInt(101);
        boolean control=false;
        Scanner input = new Scanner(System.in);
        int number;
        System.out.println(seed);
        do {
            try{
                System.out.println("Type Number");
                number = input.nextInt();
                if(number == seed){
                    control=true;
                    System.out.println("You Got It! It's exactly:"+seed);
                }else{
                    if(number > seed){
                        System.out.println("Aww you almos got it , try lower number !");
                    }else{
                        System.out.println("Its almost there ! Try higher number!");
                    }
                }
            }catch(Exception e){e.getMessage();}
        }while(control!=true);
    }
}
