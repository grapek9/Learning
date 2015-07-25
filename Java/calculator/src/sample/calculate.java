package sample;

/**
 * Created by Daniel on 2015-01-23.
 */
public class calculate {
    public int Filter(String expression){
        return TranslationToRPN(expression);
    }
    private int TranslationToRPN(String expression){
        String translatedExpression=expression;
        return doMath(translatedExpression);
    }
    private int doMath(String expression){
        int result=0;
        return result;
    }

}
