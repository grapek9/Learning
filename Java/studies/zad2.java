/**
 * Created by Daniel on 2015-04-26.
 */
public class zad2 {
    public static void main(String args[]){
        try {
            if(args.length != 3){throw new Exception("Missing or too many arguments!");}
            else {
                String s = args[0].toString();
                int a = Integer.parseInt(args[1]);
                int b = Integer.parseInt(args[2]);
                if(b<a){throw new Exception("The end index is smaller than start index");};
                if(b > s.length()) {throw new Exception("End is farther than string ;)");}
                if(a > s.length()) {throw new Exception("You went out of string");}
                System.out.println("String inputed: " + s + " and the substring is: " + s.substring(a, b + 1));
            }
        }catch(Exception e){
            System.out.println(e.getMessage());
        }
    };

}
