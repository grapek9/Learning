package PE;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

/**
 * Created by Daniel on 2015-08-25.
 */
public class Problem4 {
    public static void main(String[] Args){
        ArrayList<Integer> values = new ArrayList<Integer>();
        for(int i =100; i<1000;i++){
            for(int j = 100;j<1000;j++){
                if(isPalindrome(Integer.toString(i*j))==true){
                    values.add(i*j);
                }
            }
        }
        System.out.println(Collections.max(values));
    }
    public static boolean isPalindrome(String value){
        char[] charArray = value.toCharArray();
        for(int i=0;i<value.length();i++){
            if(charArray[i] != charArray[value.length()-i-1]){ 
                return false;
            }
        }
        return true;
    }
}
