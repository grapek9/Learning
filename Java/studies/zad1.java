/**
 * Created by Daniel on 2015-04-26.
 */
public class zad1 {
    public static void main(String args[]){
        if(args.length==3) {
            try {
                int a,b,c;
                double delta=0;
                a=Integer.parseInt(args[0]);
                b=Integer.parseInt(args[1]);
                c=Integer.parseInt(args[2]);
                System.out.println("Yay! we have function looking like:"+a+"x^2+("+b+")x+("+c+")");
                delta=Math.pow(b,2)-(4*a*c);
                if(delta<0){
                    System.out.println("Too bad delta is below 0 , result is: "+delta);
                }else if(delta==0){
                    System.out.println("There is one result! x0="+(double)(b*(-1))/(2*a));
                }else{
                    System.out.println("We have got 2 results!: x1="+((double)(b*(-1))+Math.sqrt(delta))/(2*a)+" and x2="+((double)(b*(-1))-Math.sqrt(delta))/(2*a));
                }

            }catch (NumberFormatException e) {
                System.out.println("YEAH! i have caught and exception: " + e.getMessage());

            }catch(Exception e){
                System.out.println("YEAH! i have caught and exception: "+e.getMessage());
            }
        } else{
            System.out.println("argh! arguments missing/too much !, expected 3 and you have inputed :"+args.length);
        }
    }
}
