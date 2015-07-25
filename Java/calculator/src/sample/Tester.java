package sample;


import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.stage.Stage;
import java.io.IOException;

/**
 * Created by Daniel on 2015-01-17.
 */
public class Tester extends Application{

    public void RunTests()throws IOException{
        System.out.println("Inside Tester Class");
        Stage secondaryStage = new Stage();
        start(secondaryStage);
    }
    @Override
    public void start(Stage secondaryStage) throws IOException{
        Parent root = FXMLLoader.load(getClass().getResource("TesterWindow.fxml"));
        secondaryStage.setTitle("Modules Condition");
        secondaryStage.setScene(new Scene(root, 300, 275));
        secondaryStage.show();
    }
}

