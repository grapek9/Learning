import java.io.*;
import java.nio.ByteBuffer;
import java.nio.channels.FileChannel;
import java.util.Random;

/**
 * Created by Daniel on 2015-04-30.
 */
public class zad4 {
    public static void main(String args[]) throws IOException{
        String alphabet="0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        int seed=alphabet.length();
        Random rand=new Random();
        char[] outputChar = new char[1000];
        for(int i=0;i<1000;i++){
            outputChar[i]=alphabet.charAt((rand.nextInt(seed)));
        }
        System.out.println("Generated String:");
        String outputString = new String(outputChar);
        System.out.println(outputString);
        System.out.println("");
        //  System.out.println(outputString.length());

        long startTime = System.currentTimeMillis();
        javaIOsave(outputString);
        long endTime = System.currentTimeMillis();
        System.out.println("IO:It took "+(endTime-startTime)+"ms to create file and write into it ");

        startTime = System.currentTimeMillis();
        javaIOread();
        endTime = System.currentTimeMillis();
        System.out.println("IO:It took " + (endTime - startTime) + "ms to read from file ");

        startTime= System.currentTimeMillis();
        javaNIOsave(outputString);
        endTime= System.currentTimeMillis();
        System.out.println("NIO:It took " + (endTime - startTime) + "ms to create file and write into it ");

        startTime=System.currentTimeMillis();
        javaNIOread();
        endTime = System.currentTimeMillis();
        System.out.println("NIO:It took " + (endTime - startTime) + "ms to read from file ");
    }
    public static void javaIOsave(String output)throws IOException{
        File ioFile = new File("C:\\Users\\Daniel\\Desktop\\IOFile.txt");
        if(!ioFile.exists()){
            ioFile.createNewFile();
        }
        FileOutputStream fop = new FileOutputStream(ioFile);
        byte[] outputInBytes = output.getBytes();
        fop.write(outputInBytes);
        fop.flush();
        fop.close();
    }
    public static void javaIOread()throws IOException{
        InputStream IOFile = new FileInputStream("C:\\Users\\Daniel\\Desktop\\IOFile.txt");
        int size = IOFile.available();
        char[] inputChar = new char[1000];
        for(int i=0; i< size; i++){
            inputChar[i]=(char)IOFile.read();
        }
        IOFile.close();
        String inputString = new String(inputChar);
        System.out.println(inputString);
        //  System.out.println(inputString.length());
    }
    public static void javaNIOsave(String output)throws IOException{
        RandomAccessFile NIOFile  = new RandomAccessFile("C:\\Users\\Daniel\\Desktop\\NIOFile.txt", "rw");
        FileChannel insideChannel = NIOFile.getChannel();

        ByteBuffer buffer = ByteBuffer.allocate(1000);
        buffer.clear();
        buffer.put(output.getBytes());
        buffer.flip();
        while(buffer.hasRemaining()) {
            insideChannel.write(buffer);
        }
        insideChannel.close();
    }
    public static void javaNIOread() throws IOException{
        RandomAccessFile NIOFile  = new RandomAccessFile("C:\\Users\\Daniel\\Desktop\\NIOFile.txt", "rw");
        FileChannel insideChannel = NIOFile.getChannel();

        ByteBuffer buf = ByteBuffer.allocate(1000);

        int bytesRead = insideChannel.read(buf);
        char[] inputChar = new char[1000];
        int i = 0 ;
        while (bytesRead != -1) {

            buf.flip();

            while(buf.hasRemaining()){
                inputChar[i]=(char) buf.get();
                i++;
            }

            buf.clear();
            bytesRead = insideChannel.read(buf);

        }
        insideChannel.close();
        String inputString = new String(inputChar);
        System.out.println(inputString);
    }
}
