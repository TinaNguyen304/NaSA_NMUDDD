package nasanotes.nasanotes;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;

/**
 * Created by nguyen tran hai son on 29-Nov-2017.
 */

public class edit_alarm extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.alarm);
    }
    public void onDoneClick(View view)
    {
        finish();
    }
    public void onCancelClick(View view)
    {
        finish();
    }

}
