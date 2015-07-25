import java.io.*;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;
import java.util.*;

/**
 * Created by Daniel on 2015-05-09.
 */
public class zad5 {
    public static void main (String Args[])throws IOException{
        List wektor1 = new ArrayList();
        List wektor2 = new ArrayList();
        Scanner input = new Scanner(System.in);
        String vector1 = input.nextLine();
        String vector2 = input.nextLine();
       // System.out.println(vector1);
       // System.out.println(vector2);
        char[] tempArray1 = vector1.toCharArray();
        char[] tempArray2 = vector2.toCharArray();
        int temp = 0 ;
        for(int i = 0 ; i < vector1.length() ; i++){
           try{
               temp = Integer.parseInt(Character.toString(tempArray1[i]));
               wektor1.add(temp);
           }catch (Exception e){
              // System.out.println(e.getMessage());
           }
        }
        for(int i = 0 ; i < vector1.length() ; i++){
            try{
                temp = Integer.parseInt(Character.toString(tempArray2[i]));
                wektor2.add(temp);
            }catch (Exception e){
               // System.out.println(e.getMessage());
            }
        }
       // System.out.println(wektor1.size());
        //System.out.println(wektor2.size());
        String output="";

        try{
            if(wektor1.size()!=wektor2.size()){throw new WektoryRoznejDlugosciException("Wektory Roznej dlugosci");};
            for(int i=0;i<wektor2.size();i++) {
                System.out.print(Integer.parseInt(wektor1.get(i).toString()) + Integer.parseInt(wektor2.get(i).toString()) + ",");

                temp = Integer.parseInt(wektor1.get(i).toString()) + Integer.parseInt(wektor2.get(i).toString());

                output+=temp;
                if(i!=(wektor2.size()-1)){
                    output+=",";
                }
            };
        }catch(WektoryRoznejDlugosciException e){System.out.println(e.getMessage()+" Wektor1:"+wektor1.size()+" Wektor2:"+wektor2.size());};

       // System.out.println(output);

        File ioFile = new File("C:\\Users\\Daniel\\Desktop\\Zad5.txt");
        if(!ioFile.exists()){
            ioFile.createNewFile();
        }
        FileOutputStream fop = new FileOutputStream(ioFile);
        byte[] outputInBytes = output.getBytes();
        fop.write(outputInBytes);
        fop.flush();
        fop.close();
    }

}

