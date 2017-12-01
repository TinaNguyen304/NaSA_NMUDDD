package nasanotes.nasanotes;

/**
 * Created by nguyen tran hai son on 16-Nov-2017.
 */
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.content.Intent;


public class NewNote extends AppCompatActivity{
    private EditText newnote_1;
    private Button alarm;
    //private AlarmListAdapter mAlarmListAdapter;
    //private Alarm mCurrentAlarm;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_newnote);

        newnote_1 = (EditText) findViewById(R.id.newnote_1);
        alarm = (Button) findViewById(R.id.alarm);

        alarm.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent;
                intent = new Intent(NewNote.this,edit_alarm.class   );
                startActivity(intent);
            }
        });
    }


}
