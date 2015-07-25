package fibonacci;
import java.util.Scanner;
public class fibsequence {
    public static void main(String args[]){
        int n=0;
        Scanner digit=new Scanner(System.in);
        n=digit.nextInt();
        n=fibonacci(n);
        System.out.println(n);

    }
    public static int fibonacci(int n){
        if (n==0) return 0;
        if (n==1) return 1;
        return fibonacci(n-1)+fibonacci(n-2);
    }
}