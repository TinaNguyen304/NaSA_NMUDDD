package nasanotes.nasanotes;

/**
 * Created by nguyen tran hai son on 16-Nov-2017.
 */
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

public class RecentlyDelete extends AppCompatActivity {
    private Button recover;
    private Button del_2;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_delete);

        recover = (Button) findViewById(R.id.recover);
        del_2 = (Button) findViewById(R.id.del_2);

    }
}
